using System;

namespace EifelMono.KaOS
{
    public class EnumOf<T> : IEquatable<EnumOf<T>> where T : IComparable
    {
        #region Core
        private int HashCode { get; set; }

        // I Need this for serialization
        public T Value { get; set; }

        #endregion

        #region IEquatable<EnumOf<T>> Members

        public bool Equals(EnumOf<T> other)
        {
            if ((object)other == null)
                return false;
            if (object.ReferenceEquals(Value, other.Value))
                return true;
            return Value.CompareTo(other.Value) == 0;
        }
        #endregion

        #region Others
        public override bool Equals(object obj)
        {
            return Equals(obj as EnumOf<T>);
        }

        public override int GetHashCode()
        {
            if (HashCode == 0)
                HashCode = Value.GetHashCode();
            return HashCode;
        }

        public override string ToString()
        {
            return $"{Value:[HasCode]}";
        }

        public static bool operator ==(EnumOf<T> left, EnumOf<T> right)
        {
            if ((object)left == null)
                return ((object)right == null);
            else if ((object)right == null)
                return ((object)left == null);
            return left.Equals(right);
        }

        public static bool operator !=(EnumOf<T> left, EnumOf<T> right)
        {
            return !(left == right);
        }
        #endregion
    }
}

