/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SharpLLVM {

public struct TargetLibraryInfoRef : System.IEquatable<TargetLibraryInfoRef> {
    public TargetLibraryInfoRef(global::System.IntPtr cPtr)
    {
        Value = cPtr;
    }

    public System.IntPtr Value;
    
    public bool Equals(TargetLibraryInfoRef other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        return obj is TargetLibraryInfoRef && Equals((TargetLibraryInfoRef)obj);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public static bool operator ==(TargetLibraryInfoRef left, TargetLibraryInfoRef right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(TargetLibraryInfoRef left, TargetLibraryInfoRef right)
    {
        return !left.Equals(right);
    }
}

}
