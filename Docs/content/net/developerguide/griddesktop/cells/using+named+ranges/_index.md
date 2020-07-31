---
title : "Using Named Ranges" 
description : "" 
weight : 16647 
toc : false
type: docs
url: /net/developerguide/griddesktop/cells/using+named+ranges/
---

# Aspose.Cells for .NET : Using Named Ranges


Normally, you use the labels of columns and rows on a worksheet to refer to the cells within those columns and rows. But you can create descriptive names to represent cells, ranges of cells, formulas, or constant values. The word **Name** may refer to a string of characters that represents a cell, range of cells, formula, or constant value. For example, Use easy-to-understand names, such as Products, to refer to hard to understand ranges, such as Sales!C20:C30 to represent a cell, range of cells, formula, or constant value. Labels can be used in formulas that refer to data on the same worksheet; if you want to represent a range on another worksheet, you may use a name. **Named Ranges** are among the most powerful features of Microsoft. Users may assign a name to a named range so that this range of cells can be referred with its name in the formulas. **Aspose.Cells.Grid****Desktop** does support this feature.

## Adding/Referencing Named Ranges in Formulas

The GridDesktop control does support to import/export named ranges in the Excel files, it provides two classes (**Name** and **NameCollection**) to work with named ranges.

Following code snippet will help you how to use them.

