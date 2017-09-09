// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.ReturnValue, Inherited = false)]
    public sealed class MarshalAsAttribute : Attribute
    {
        private UnmanagedType _val;

        public MarshalAsAttribute(UnmanagedType unmanagedType)
        {
            _val = unmanagedType;
        }
        public MarshalAsAttribute(short unmanagedType)
        {
            _val = (UnmanagedType)unmanagedType;
        }

        public UnmanagedType Value => _val;

        // Fields used with SubType = SafeArray.
        public VarEnum SafeArraySubType;
        public Type SafeArrayUserDefinedSubType;

        // Field used with iid_is attribute (interface pointers).
        public int IidParameterIndex;

        // Fields used with SubType = ByValArray and LPArray.
        // Array size =  parameter(PI) * PM + C
        public UnmanagedType ArraySubType;
        public short SizeParamIndex;           // param index PI
        public int SizeConst;                // constant C

        // Fields used with SubType = CustomMarshaler
        public string MarshalType;              // Name of marshaler class
        public Type MarshalTypeRef;           // Type of marshaler class
        public string MarshalCookie;            // cookie to pass to marshaler
    }
}
