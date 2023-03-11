﻿# Requirements

1. Given I have selected to add an item to the basket
   Then the item should be added to the basket

2. Given items have been added to the basket
   Then the total cost of the basket should be calculated

3. Given I have added a multiple of 3 lots of item ‘B’ to the basket
   Then a promotion of ‘3 for 40’ should be applied to every multiple of 3 (see table).

4. Given I have added a multiple of 2 lots of item ‘D’ to the basket
   Then a promotion of ‘25% off’ should be applied to every multiple of 2 (see table).

|  Item SKU  |  Unit Price  |  Promotions                              |
|------------|--------------|------------------------------------------|
|     A      |      10      |                                          |
|     B      |      15      |  3 for 40                                |
|     C      |      40      |                                          |
|     D      |      55      |  25% off for every 2 purchased together  |

Items are priced individually.
In addition, there are promotions which can affect the total price of the basket, for example,
when 3 lots of item ‘D’ are added to the basket then a 25% deduction is applied to the total cost of 2 of those items.
The pricing changes frequently, so pricing should be independent of the checkout.

* Commit frequently to show approach taken
* Complete Kata in C#
* Demonstrate your understanding of good coding, testing, and design practices
* Feel free to provide any explanation or decisions taken in the readme file