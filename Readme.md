<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128640226/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T596852)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Accordion - Bind to Data (HierarchicalDataTemplate)

This example binds the [WPF Accordion Control](https://docs.devexpress.com/WPF/118347/controls-and-libraries/navigation-controls/accordion-control) to data (`MyData.Categories`) and uses [System.Windows.HierarchicalDataTemplate](https://learn.microsoft.com/en-us/dotnet/api/system.windows.hierarchicaldatatemplate?view=windowsdesktop-8.0&redirectedfrom=MSDN) to present accordion items.

```xaml
<dxa:AccordionControl x:Name="accordion" SelectionUnit="SubItem" 
        ItemsSource="{Binding MyData.Categories }" SelectedItem="{Binding SelectedItem}">
    <dxa:AccordionControl.ItemTemplate>
        <HierarchicalDataTemplate DataType="{x:Type local:Category}" ItemsSource="{Binding Items}">
            <TextBlock Text="{Binding CategoryName}"/>
            <HierarchicalDataTemplate.ItemTemplate>
                <DataTemplate DataType="{x:Type local:Item}">
                    <TextBlock Text="{Binding ItemName}"/>
                </DataTemplate>
            </HierarchicalDataTemplate.ItemTemplate>
        </HierarchicalDataTemplate>
    </dxa:AccordionControl.ItemTemplate>
</dxa:AccordionControl>
```

![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-bind-the-accordioncontrol-to-data-using-the-hierarchicaldata-template-t596852/22.2.2%2B/i/wpf-accordion-control-hierarchical-data-template-devexpress.png)


## Files to Review

* [MainWindow.xaml](./CS/HierarchicalDataTemplate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HierarchicalDataTemplate/MainWindow.xaml))
* [ViewModel.cs](./CS/HierarchicalDataTemplate/ViewModel.cs) (VB: [ViewModel.vb](./VB/HierarchicalDataTemplate/ViewModel.vb))


## Documentation

* [AccordionControl.ItemTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Accordion.AccordionControl.ItemTemplate)
* [WPF Accordion - Data Binding](https://docs.devexpress.com/WPF/118635/controls-and-libraries/navigation-controls/accordion-control/data-binding)
