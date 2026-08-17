# Simple Tag Manager

## Feature list 
- Enter new tags
- Show current tags
- Save tags to file
- Load tags from file
- Exit

## Program structure

### Tag
 - A class that represents "data" in the program

### TagPrinter
 - Prints tags to the user

### TagService
 - a class that does business logic

### TagRepository
 - a class that saves and loads data

### Program
 - The entry point. It starts the program and connects the difference pieces together. 
   - Currently it also handles state of the tagslist (todofix)


#### Notes on class modelling

a class is basically:

1. State (tilstand / data / innhold)
2. Behavior (oppførsel / funksjonalitet)

Example:

BankAccount class:
 - State: Balance, Account number, and so on.
 - Behavior: Deposit, Withdraw

ShoppingCart class:
 - State: Products
 - Behavior: AddProduct, RemoveProduct, ClearCart

TagManager class:
 - State: tags
 - Behavior: AddTags, RemoveTags, GetTags, and so on (replace tags?)