﻿using System.Windows;
using System.Windows.Controls;

namespace Its.Onix.Ui.Client.Skeleton.Commons
{
    public partial class UFormContainer : UserControl
    {
        public static readonly DependencyProperty FormWidthProperty =
            DependencyProperty.Register("FormWidth", typeof(double), typeof(UFormContainer),
            new UIPropertyMetadata(500.00, new PropertyChangedCallback(OnFormWidthChanged)), ValidateFormWidthValue);

        public static readonly DependencyProperty FormHeightProperty =
            DependencyProperty.Register("FormHeight", typeof(double), typeof(UFormContainer),
            new UIPropertyMetadata(400.00, new PropertyChangedCallback(OnFormHeightChanged)), ValidateFormHeightValue);

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(UFormContainer),
            new UIPropertyMetadata("", new PropertyChangedCallback(OnCaptionChanged)));


        #region FormWidth
        private static void OnFormWidthChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
        }

        private static bool ValidateFormWidthValue(object value)
        {
            return (true);
        }

        public double FormWidth
        {
            get 
            { 
                return (double) GetValue(FormWidthProperty); 
            }

            set 
            { 
                SetValue(FormWidthProperty, value); 
            }
        }
        #endregion FormWidth


        #region FormHeight
        private static void OnFormHeightChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
        }

        private static bool ValidateFormHeightValue(object value)
        {
            return (true);
        }

        public double FormHeight
        {
            get
            {
                return (double)GetValue(FormHeightProperty);
            }

            set
            {
                SetValue(FormHeightProperty, value);
            }
        }
        #endregion FormHeight

        #region Caption
        private static void OnCaptionChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
        }

        public string Caption
        {
            get
            {
                return (string) GetValue(CaptionProperty);
            }

            set
            {
                SetValue(CaptionProperty, value);
            }
        }
        #endregion Caption

        public UFormContainer()
        {
            DataContext = this;

            InitializeComponent();
        }
    }
}
