+++
title = "Security Exception Issue" 
description = "" 
weight = 12025 
+++

Aspose.Cells for .NET : Security Exception Issue  

# Aspose.Cells for .NET : Security Exception Issue


**Contents Summary**

/\*<!\[CDATA\[\*/div.rbtoc1590738020681 {padding: 0px;}div.rbtoc1590738020681 ul {list-style: none;margin-left: 0px;}div.rbtoc1590738020681 li {margin-left: 0px;padding-left: 0px;}/\*\]\]>\*/

*   1 [Security Exception Problem](#SecurityExceptionIssue-SecurityExceptionProblem)
    *   1.1 [Explanation](#SecurityExceptionIssue-Explanation)
    *   1.2 [Solution](#SecurityExceptionIssue-Solution)

## Security Exception Problem

Some users may receive "Security Exception" error while trying to use Aspose.Cells. This problem is generally happened in a web application.

### Explanation

Aspose.Cells has to call some **Win32 GDI APIs** to provide some important features. If the web server has a strict trust level, this security exception may be thrown.

### Solution

Please try to create a new permission set to give Aspose.Cells.dll security permission with "Allow calls to unmanaged assemblies" enabled.

