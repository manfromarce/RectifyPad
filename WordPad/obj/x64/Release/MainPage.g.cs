﻿#pragma checksum "D:\Visual Studio\Repos\RectifyPad\RectifyPad\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E37D574B1C7D459E6C1455A31E84DC3B08749390D9F49344A15C9031C4660E49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RectifyPad
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::RectifyPad.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Border obj50;
            private global::Windows.UI.Xaml.Controls.TextBlock obj51;
            private global::Windows.UI.Xaml.Controls.TextBlock obj62;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 50: // MainPage.xaml line 904
                        this.obj50 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 51: // MainPage.xaml line 915
                        this.obj51 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 62: // MainPage.xaml line 513
                        this.obj62 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::RectifyPad.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::RectifyPad.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_StatusbarToggle(obj.StatusbarToggle, phase);
                        this.Update_ZoomSlider(obj.ZoomSlider, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FullString(obj.FullString, phase);
                    }
                }
            }
            private void Update_StatusbarToggle(global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_StatusbarToggle(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_StatusbarToggle_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_StatusbarToggle_IsChecked(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_StatusbarToggle_IsChecked_Cast_IsChecked_To_Visibility(obj ? global::Windows.UI.Xaml.Visibility.Visible : global::Windows.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_StatusbarToggle_IsChecked_Cast_IsChecked_To_Visibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 904
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj50, obj);
                }
            }
            private void Update_ZoomSlider(global::Windows.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ZoomSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ZoomSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_ZoomSlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 915
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj51, obj.ToString(), null);
                }
            }
            private void Update_FullString(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 513
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj62, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_StatusbarToggle(null);
                    UpdateChildListeners_ZoomSlider(null);
                }

                public void DependencyPropertyChanged_StatusbarToggle_IsChecked(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem obj = sender as global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem;
                        if (obj != null)
                        {
                            bindings.Update_StatusbarToggle_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem cache_StatusbarToggle = null;
                private long tokenDPC_StatusbarToggle_IsChecked = 0;
                public void UpdateChildListeners_StatusbarToggle(global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem obj)
                {
                    if (obj != cache_StatusbarToggle)
                    {
                        if (cache_StatusbarToggle != null)
                        {
                            cache_StatusbarToggle.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem.IsCheckedProperty, tokenDPC_StatusbarToggle_IsChecked);
                            cache_StatusbarToggle = null;
                        }
                        if (obj != null)
                        {
                            cache_StatusbarToggle = obj;
                            tokenDPC_StatusbarToggle_IsChecked = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem.IsCheckedProperty, DependencyPropertyChanged_StatusbarToggle_IsChecked);
                        }
                    }
                }
                public void DependencyPropertyChanged_ZoomSlider_Value(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.Slider obj = sender as global::Windows.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_ZoomSlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Slider cache_ZoomSlider = null;
                private long tokenDPC_ZoomSlider_Value = 0;
                public void UpdateChildListeners_ZoomSlider(global::Windows.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_ZoomSlider)
                    {
                        if (cache_ZoomSlider != null)
                        {
                            cache_ZoomSlider.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_ZoomSlider_Value);
                            cache_ZoomSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_ZoomSlider = obj;
                            tokenDPC_ZoomSlider_Value = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_ZoomSlider_Value);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 46: // MainPage.xaml line 501
                {
                    this.AppTitleBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 47: // MainPage.xaml line 520
                {
                    this.MenuStack = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 48: // MainPage.xaml line 619
                {
                    global::Windows.UI.Xaml.Controls.Button element48 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element48).Click += this.Feedback_Click;
                }
                break;
            case 49: // MainPage.xaml line 885
                {
                    this.EditorContentHost = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)this.EditorContentHost).SizeChanged += this.EditorContentHost_SizeChanged;
                }
                break;
            case 52: // MainPage.xaml line 936
                {
                    this.ZoomSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.ZoomSlider).ValueChanged += this.ZoomSlider_ValueChanged;
                }
                break;
            case 53: // MainPage.xaml line 898
                {
                    this.Editor = (global::Windows.UI.Xaml.Controls.RichEditBox)(target);
                }
                break;
            case 54: // MainPage.xaml line 650
                {
                    this.ClipbrdHost = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 55: // MainPage.xaml line 663
                {
                    global::Microsoft.UI.Xaml.Controls.SplitButton element55 = (global::Microsoft.UI.Xaml.Controls.SplitButton)(target);
                    ((global::Microsoft.UI.Xaml.Controls.SplitButton)element55).Click += this.Paste_Click;
                }
                break;
            case 56: // MainPage.xaml line 688
                {
                    global::Windows.UI.Xaml.Controls.Button element56 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element56).Click += this.Cut_Click;
                }
                break;
            case 57: // MainPage.xaml line 701
                {
                    global::Windows.UI.Xaml.Controls.Button element57 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element57).Click += this.Copy_Click;
                }
                break;
            case 58: // MainPage.xaml line 607
                {
                    global::Windows.UI.Xaml.Controls.Button element58 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element58).Click += this.Undo_Click;
                }
                break;
            case 59: // MainPage.xaml line 612
                {
                    global::Windows.UI.Xaml.Controls.Button element59 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element59).Click += this.Redo_Click;
                }
                break;
            case 60: // MainPage.xaml line 596
                {
                    this.StatusbarToggle = (global::Windows.UI.Xaml.Controls.ToggleMenuFlyoutItem)(target);
                }
                break;
            case 61: // MainPage.xaml line 534
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element61 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element61).Click += this.Open_Click;
                }
                break;
            case 62: // MainPage.xaml line 513
                {
                    this.tea = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
