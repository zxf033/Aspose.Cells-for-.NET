---
title : "Working with GridWeb Double Click Events" 
description : "" 
weight : 16667 
toc : false
type: docs
url: /net/developerguide/gridweb/workingwithgridweb/working+with+gridweb+double+click+events/
---

# Aspose.Cells for .NET : Working with GridWeb Double Click Events


Aspose.Cells.GridWeb contains three types of double-click events:

*   CellDoubleClick, fired when a cell is double-clicked.
*   ColumnDoubleClick, fired when a column header is double-clicked.
*   RowDoubleClick, fired when a row header is double-clicked.

This topic discusses how to enable double-click events in Aspose.Cells.GridWeb. It also discusses creating event handlers for these events.

{{< panel title="Contents Summary" style="primary" >}}
*   1 [Enabling Double Click Events](#enabling-double-click-events)
*   2 [Handling Double Click Events](#handling-double-click-events)
    *   2.1 [Double Click Cell](#double-click-cell)
    *   2.2 [Double Click Column Header](#double-click-column-header)
    *   2.3 [Double Click Row Header](#double-click-row-header)
{{< /panel >}}
 

## Enabling Double Click Events

All types of double click events can be enabled client-side by setting the GridWeb control's `EnableDoubleClickEvent` property to true.

By default, the `EnableDoubleClickEvent` property is set to false. This means that double click events are not enabled by default. To implement such events, first enable the feature.

Once double-click events are enabled, it is possible to create event handlers for any double-click events. These event handlers perform specific tasks when a given double-click event is fired.

## Handling Double Click Events

To create an event handler in Visual Studio:

1.  Double-click an event in the **Events** list in the Properties pane.

For this example, we implemented event handlers for various double-click events.

### Double Click Cell

The event handler for the `CellDoubleClick` event provides an argument of the `CellEventArgs` type, which provides the complete information of the cell that is double-clicked.

### Double Click Column Header

The event handler for the `ColumnDoubleClick` event provides an argument of the `RowColumnEventArgs` type that provides the index number of the column for the header that was double-clicked and other information.

### Double Click Row Header

The event handler for the `RowDoubleClick` event provides an argument of the `RowColumnEventArgs` type that provides the index number of the row for the header that was double-clicked and other related information.

