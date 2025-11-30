# Bind the RibbonCheckBox in WPF Ribbon Control with MVVM
This sample demonstrates how to data bind a Syncfusion RibbonCheckBox inside a WPF Ribbon using the MVVM pattern. It shows binding the IsChecked state to a view-model property, templating items, commanding, and theming so you can build Office-style ribbons with fully databound toggle behavior.

## Features
- MVVM bindings for RibbonCheckBox (IsChecked TwoWay)
- ICommand support (Command and CommandParameter)
- Data templating: generate RibbonBar items from a collection
- Tri-state support via IsThreeState with nullable bool (bool?)
- Enable/disable via CanExecute on commands
- KeyTips/ToolTips, icons, and labels consistent with Ribbon UI
- Works with Syncfusion themes (e.g., Office2016Colorful)

## How it works in this sample
- ItemsSource on Ribbon is bound to ViewModel.CustomChild1RibbonTabs
- Each RibbonTab binds to a collection of RibbonBar view models
- Each RibbonBar binds to CustomRibbonItems
- A DataTemplate selects the control type; for checkboxes it uses RibbonCheckBox
- RibbonCheckBox.Content binds to ItemHeader and IsChecked binds to Checked

## Usage Tips
- Use Mode=TwoWay for IsChecked so UI and ViewModel stay in sync.
- Prefer a nullable bool (bool?) in your ViewModel when enabling IsThreeState.
- Implement ICommand.CanExecute to dynamically enable/disable the checkbox.
- Add KeyTip and ToolTip for better keyboard navigation and discoverability.
- Persist the bound properties to restore user preferences on startup.

## About this sample
The sample generates Ribbon content from view-model collections and binds RibbonCheckBox states to model properties, demonstrating a clean MVVM approach suitable for toggling features like headers, totals, and banded rows.
