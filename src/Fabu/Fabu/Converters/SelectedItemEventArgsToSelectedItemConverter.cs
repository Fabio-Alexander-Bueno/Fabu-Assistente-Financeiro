﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Fabu.Converters
{
    public class SelectedItemEventArgsToSelectedItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Clean the ListView.SelectedItem if "Source" property from "EventToCommandBehavior" exists in XAML
            if (parameter != null && parameter is ListView)
                if (((ListView)parameter).SelectedItem != null)
                    ((ListView)parameter).SelectedItem = null;

            var eventArgs = value as SelectedItemChangedEventArgs;
            return eventArgs.SelectedItem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
