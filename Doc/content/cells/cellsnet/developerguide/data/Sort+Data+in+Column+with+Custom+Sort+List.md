+++
title = "Sort Data in Column with Custom Sort List" 
description = "" 
weight = 12217 
+++

Aspose.Cells for .NET : Sort Data in Column with Custom Sort List  

# Aspose.Cells for .NET : Sort Data in Column with Custom Sort List


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738046371 {padding: 0px;}div.rbtoc1590738046371 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738046371 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Possible Usage Scenarios ](#SortDatainColumnwithCustomSortList-PossibleUsageScenarios)
*   2 [Sort Data in Column with Custom Sort List](#SortDatainColumnwithCustomSortList-SortDatainColumnwithCustomSortList)
*   3 [Sample Code](#SortDatainColumnwithCustomSortList-SampleCode)

## Possible Usage Scenarios 

You can sort data in the column using a custom list. This can be done using [DataSorter.AddKey(int key, SortOrder order, String customList)](https://apireference.aspose.com/net/cells/aspose.cells.datasorter/addkey/methods/2) method. However, this method works only if the items in the custom list do not have commas inside them. If they have commas like "USA,US", "China,CN" etc., then you must use [DataSorter.AddKey(int key, SortOrder order, String\[\] customList)](https://apireference.aspose.com/net/cells/aspose.cells.datasorter/addkey/methods/3) method. Here, the last parameter is not String but an Array of Strings.

## Sort Data in Column with Custom Sort List



## Sample Code

## Attachments:


