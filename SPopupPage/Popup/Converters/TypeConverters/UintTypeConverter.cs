﻿using System;
using Xamarin.Forms;

namespace Popup
{
    public class UintTypeConverter : TypeConverter
    {
        public override object ConvertFromInvariantString(string value)
        {
            try
            {
                return Convert.ToUInt32(value);
            }
            catch (Exception)
            {
                throw new InvalidOperationException($"Cannot convert {value} into {typeof(uint)}");
            }
        }
    }
}
