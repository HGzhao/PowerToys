﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;
using ColorPicker.Models;

namespace ColorPicker.ViewModelContracts
{
    public interface IColorEditorViewModel
    {
        event EventHandler OpenColorPickerRequested;

        ICommand OpenColorPickerCommand { get; }

        ICommand RemoveColorCommand { get; }

        ICommand SelectedColorChangedCommand { get; }

        ICommand HideColorFormatCommand { get; }

        ObservableCollection<ColorFormatModel> ColorRepresentations { get; }

        ObservableCollection<Color> ColorsHistory { get; }

        ObservableCollection<string> AvailableColorFormats { get; }

        Color SelectedColor { get; set; }

        string SelectedColorFormat { get; set; }

        int SelectedColorIndex { get; set; }

        void Initialize();
    }
}
