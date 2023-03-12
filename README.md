# Requirements

* Given I have selected to add an item to the basket, then the item should be added to the basket

* Given items have been added to the basket, then the total cost of the basket should be calculated

* Given I have added a multiple of 3 lots of item ‘B’ to the basket, then a promotion of ‘3 for 40’ should be applied to every multiple of 3 (see table).

* Given I have added a multiple of 2 lots of item ‘D’ to the basket, then a promotion of ‘25% off’ should be applied to every multiple of 2 (see table). To clarify, if 3 lots of this item are added to the basket then a 25% deduction is only applied to the total cost of 2.

* Items are priced individually.

* The pricing changes frequently, so pricing should be independent of the checkout.

|  Item SKU  |  Unit Price  |  Promotions                              |
|------------|--------------|------------------------------------------|
|     A      |      10      |                                          |
|     B      |      15      |  3 for 40                                |
|     C      |      40      |                                          |
|     D      |      55      |  25% off for every 2 purchased together  |