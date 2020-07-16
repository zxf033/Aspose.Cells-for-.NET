+++
title = "Specifying the Absolute Position of the Pivot Item" 
description = "" 
weight = 20417 
+++

Aspose.Cells for .NET : Specifying the Absolute Position of the Pivot Item  

# Aspose.Cells for .NET : Specifying the Absolute Position of the Pivot Item


Sometimes, user needs to specify the absolute position of the pivot items, Aspose.Cells API has exposed few new properties and a method to achieve user requirement.

*   Added `PivotItem.Position` property that can be used to specify the position index in all the PivotItems regardless of the parent node. Added `PivotItem.PositionInSameParentNode` property that can be used to specify the position index in the PivotItems under the same parent node.

*   Added `PivotItem.Move(int count, bool isSameParent)` method in order to move the item up or down based on the count value, where count is the number of position to move the PivotItem up or down. If the count value is less than zero, the item will be moved up where as if the count value is larger than zero, the PivotItem will move down, Boolean type isSameParent parameter specify whether the moving operation has to be performed in the same parent node or not.

*   Obsoleted the `PivotItem.Move(int count)` method therefore it is suggested to use the newly added method `PivotItem.Move(int count, bool isSameParent)` instead.


Please note, it is necessary to call the `PivotTable.RefreshData` and `PivotTable.CalculateData` methods before using `PivotItem.Position`, `PivotItem.PositionInSameParentNode` properties and `PivotItem.Move(int count, bool isSameParent)` method.

## Attachments:


