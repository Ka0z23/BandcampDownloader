﻿using System;
using System.Globalization;
using System.Windows.Controls;

namespace BandcampDownloader {

    internal class DoubleRule: ValidationRule {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            if (Double.TryParse(value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out Double doubleValue)) {
                return new ValidationResult(true, null);
            } else {
                return new ValidationResult(false, "Not a numeric value");
            }
        }
    }
}