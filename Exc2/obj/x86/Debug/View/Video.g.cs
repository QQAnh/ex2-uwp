﻿#pragma checksum "C:\Users\Nam\Desktop\New folder (2)\exc2-uwp\Exc2\View\Video.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "448A979E947B88FBEDCBAE9AEBD3C21D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exc2.View
{
    partial class Video : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Video_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IVideo_Bindings
        {
            private global::Exc2.View.Video dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj3;

            private Video_obj1_BindingsTracking bindingsTracking;

            public Video_obj1_Bindings()
            {
                this.bindingsTracking = new Video_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // View\Video.xaml line 15
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    default:
                        break;
                }
            }

            // IVideo_Bindings

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
                    this.dataRoot = (global::Exc2.View.Video)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Exc2.View.Video obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Videos(obj.Videos, phase);
                    }
                }
            }
            private void Update_Videos(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Videos(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // View\Video.xaml line 15
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                }
            }
            private void UpdateTwoWay_3_ItemsSource()
            {
                if (this.initialized)
                {
                    this.dataRoot.Videos = (global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile>)this.obj3.ItemsSource;
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Video_obj1_BindingsTracking
            {
                private global::System.WeakReference<Video_obj1_Bindings> weakRefToBindingObj; 

                public Video_obj1_BindingsTracking(Video_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Video_obj1_Bindings>(obj);
                }

                public Video_obj1_Bindings TryGetBindingObject()
                {
                    Video_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_Videos(null);
                }

                public void PropertyChanged_Videos(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Video_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_Videos(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    Video_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile> cache_Videos = null;
                public void UpdateChildListeners_Videos(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.Storage.StorageFile> obj)
                {
                    if (obj != cache_Videos)
                    {
                        if (cache_Videos != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Videos).PropertyChanged -= PropertyChanged_Videos;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_Videos).CollectionChanged -= CollectionChanged_Videos;
                            cache_Videos = null;
                        }
                        if (obj != null)
                        {
                            cache_Videos = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Videos;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_Videos;
                        }
                    }
                }
                public void RegisterTwoWayListener_3(global::Windows.UI.Xaml.Controls.ListView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_ItemsSource();
                        }
                    });
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\Video.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.OnSelectFolder;
                }
                break;
            case 3: // View\Video.xaml line 15
                {
                    this.ListViewMusic = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListViewMusic).SelectionChanged += this.OnSelectVideo;
                }
                break;
            case 4: // View\Video.xaml line 29
                {
                    this.VideoPlayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // View\Video.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Video_obj1_Bindings bindings = new Video_obj1_Bindings();
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

