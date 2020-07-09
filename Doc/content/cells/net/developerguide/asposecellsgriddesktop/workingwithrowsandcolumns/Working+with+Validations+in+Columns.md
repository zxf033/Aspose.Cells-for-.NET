+++
title = "Working with Validations in Columns" 
description = "" 
weight = 16631 
+++

Aspose.Cells for .NET : Working with Validations in Columns  

# Aspose.Cells for .NET : Working with Validations in Columns


In one of our previous topics, we have discussed about validations but that was in the context of [Validations in Worksheets](http://localhost:1313/cellsnet/developerguide/asposecellsgriddesktop/workingwithworksheet/working+with+validations+in+worksheets) (for having general information about validation and validation modes, developers can refer to this topic). In this topic, we will explain validations with respect to columns. Using this feature, it is possible for developers to apply a validation rule on any column of the worksheet. Let's discuss it in detail.

**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738145485 {padding: 0px;}div.rbtoc1590738145485 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738145485 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Adding Column Validation](#WorkingwithValidationsinColumns-AddingColumnValidation)
*   2 [Accessing Column Validation](#WorkingwithValidationsinColumns-AccessingColumnValidation)
*   3 [Removing Column Validation](#WorkingwithValidationsinColumns-RemovingColumnValidation)

 

 

## Adding Column Validation

To add any kind of validation to a column, please follow the steps below:

*   Add Aspose.Cells.GridDesktop control to your **Form**
*   Access any desired **Worksheet**
*   **Add** a desired **Validation** to any column

**IMPORTANT:** For more information about the types of validation (or validation modes like **Is Required Validation**, **Regular Expressions Validation** and **Custom Validation**) and implementing **Custom Validation**, please refer to [Working with Validations in Worksheets.](http://localhost:1313/cellsnet/developerguide/asposecellsgriddesktop/workingwithworksheet/working+with+validations+in+worksheets)

## Accessing Column Validation

To access a specific column validation, please follow the steps below:

*   Access a desired **Worksheet**
*   Access a specific column **Validation** in the **Worksheet**
*   Edit **Validation** attributes, if desired

//Accessing first worksheet of the GridWorksheet sheet = gridDesktop1.Worksheets\[0\];//Accessing the Validation object applied on a specific columnValidation validation = sheet.Columns\[2\].Validation;//Editing the attributes of Validationvalidation.IsRequired = true;validation.RegEx = "";validation.CustomValidation = null;

## Removing Column Validation

To remove a specific column validation from the worksheet, please follow the steps below:

*   Access a desired **Worksheet**
*   Remove a specific column **Validation** from the **Worksheet**

//Accessing first worksheet of the GridWorksheet sheet = gridDesktop1.Worksheets\[0\];//Removing the Validation applied on a specific columnsheet.Columns\[2\].RemoveValidation();

