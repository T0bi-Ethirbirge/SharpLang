/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SharpLLVM {

public struct UseRef : System.IEquatable<UseRef> {
    public UseRef(global::System.IntPtr cPtr)
    {
        Value = cPtr;
    }

    public System.IntPtr Value;
    
    public bool Equals(UseRef other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        return obj is UseRef && Equals((UseRef)obj);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public static bool operator ==(UseRef left, UseRef right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(UseRef left, UseRef right)
    {
        return !left.Equals(right);
    }
}

}
