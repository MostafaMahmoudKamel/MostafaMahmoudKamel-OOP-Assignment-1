1) becouse having 20-property is too many for constructor and 
is difficult to create an object with 20 parmaeterrs 
and when i create an object with 20 parameters it is easy to make mistakes and
switch the order of the parameters which lead me many error 
such as replace two decimal or two string compiler doen't detect the mistake


2) No, it is not only a problem with the constructor being too long.
 and having problem because the class has  20=properties that are loosely related.
This makes the class harder to understand and maintain because it contains many different responsibilities in one place.
It may be better to group related properties into smaller classes.

Task 3.3)
single responsibility: each small builder manages and validates only its specific component (e.g., addressbuilder handles addresses, invoicebuilder handles overall assembly).

independent validation: addressbuilder encapsulates and enforces its own address rules independently, keeping the parent invoicebuilder completely decoupled from street, city, or zip validation logic.

reuse: addressbuilder can be reused directly for both billing and shipping addresses, eliminating duplicate address properties and validation code.

readability at call site: composed builders create a clean, hierarchical structure at the call site that naturally mirrors the object's real domain model.



