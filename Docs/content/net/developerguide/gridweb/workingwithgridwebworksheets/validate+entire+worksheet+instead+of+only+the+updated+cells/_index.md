---
title : "Validate entire worksheet instead of only the updated cells" 
description : "" 
weight : 16696 
toc : false
type: docs
url: /net/developerguide/gridweb/workingwithgridwebworksheets/validate+entire+worksheet+instead+of+only+the+updated+cells/
---

# Aspose.Cells for .NET : Validate entire worksheet instead of only the updated cells


{{< panel title="Contents Summary" style="primary" >}}
*   1 [Possible Usage Scenarios](#possible-usage-scenarios)
*   2 [Validate entire worksheet instead of only the updated cells](#validate-entire-worksheet-instead-of-only-the-updated-cells)
{{< /panel >}}
 

## Possible Usage Scenarios

By default, GridWeb validates only the updated cells and does not validate the entire worksheet. However, if you want to validate entire worksheet on client side before GridWeb posts request to server, then you should set the `needValidateall` variable inside the `acwmain.js` to `true`.

## Validate entire worksheet instead of only the updated cells

The following screenshot displays the `needValidateall` variable in `acwmain.js`. Please set it to `true` and now GridWeb will validate your entire worksheet not just the updated cells.

![](https://docs2.aspose.com/cells/net/attachments/40142278/40468499.png)

