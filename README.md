# Visualizing ICC Trophy Wins by Team Using Syncfusion .NET MAUI Treemap Chart

## Overview

This .NET MAUI application visualizes the ICC trophy wins of various cricketing nations using Syncfusion's data visualization controls. It features an interactive `TreeMap chart` to compare total title wins by country and a `Circular Chart` to drill down into the types of trophies (ODI, T20, Test) won by each team.

## Features

### TreeMap Chart (SfTreeMap)
- **Purpose**: 
The TreeMap chart is used to display hierarchical or grouped data as a set of nested rectangles. In this application, it visualizes the total ICC title wins by country, where each rectangle represents a country and its size corresponds to the number of titles won.

- **Control**:
`SfTreeMap` is a Syncfusion control that supports various layout types (like Squarified, Slice and Dice) and allows for color mapping, tooltips, and drill-down interactions.

- **Interactivity**:
Users can tap on a country to trigger navigation or display a detailed breakdown of that country’s trophy wins in another chart (like a Circular Chart).

### Circular Chart (SfCircularChart)
- **Purpose**:
This chart provides a category-wise breakdown of a selected country’s ICC trophies—such as ODI World Cups, T20 World Cups, and Test Championships.

- **Control**:
`SfCircularChart` is a versatile charting control from Syncfusion that supports pie, doughnut, and radial bar charts. In this case, the doughnut chart format is used for a clean and modern look.

- **Color Mapping**:
Each trophy category is assigned a distinct color, making it easy to visually differentiate between them at a glance.

After executing these code examples, we will get the output that resembles the following image.

![TreeMap Chart](https://github.com/user-attachments/assets/30de8bc2-37ff-4ed7-b65a-9d20109d7b65)

## Resources

- [Syncfusion .NET MAUI TreeMap Documentation](https://help.syncfusion.com/maui/treemap/overview)
- [Syncfusion .NET MAUI Circular Chart Documentation](https://help.syncfusion.com/maui/cartesian-charts/overview)
- [Syncfusion MAUI Controls](https://help.syncfusion.com/maui/introduction/overview)

## Troubleshooting

### Path Too Long Exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

For a step-by-step procedure, refer to the [Visualizing ICC Trophy Wins by Team Using Syncfusion .NET MAUI Treemap Chart](#).
