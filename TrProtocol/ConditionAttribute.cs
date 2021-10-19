﻿using System;

namespace TrProtocol
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public sealed class S2COnlyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public sealed class C2SOnlyAttribute : Attribute
    {

    }


    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ArraySizeAttribute : Attribute
    {
        public int size;

        public ArraySizeAttribute(int size)
        {
            this.size = size;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ConditionAttribute : Attribute
    {
        public string field;
        public sbyte bit;
        public bool pred;

        public ConditionAttribute(string field, sbyte bit = -1, bool pred = true)
        {
            this.bit = bit;
            this.field = field;
            this.pred = pred;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class IgnoreAttribute : Attribute
    {
    }
}
