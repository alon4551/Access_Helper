### SQL_Generator
This are files that help a developer create their own SQL queries without having to deal with syntax.
For this projects there are **3** basic classes that help build the SQL Queries:
- Col
- Row
- Condition

## Class **Col** 
Represent a *Column* in Database, each column has a value and a field name
has Props of:
```C#
        private string Field {get;set;}//the field name of a colume
        private object Value {get;set;}//the value of the field (can be any value)
```

Constructors: 
- (**string** field, **object** value) create a new Column with the data
- ***no empty constructos***

Class **Col** has public actions :

1. ```Set``` setting the colume data :
  - (**string** field, **object** value) 
  - (**Col** col)
  
2. ```GetValue()``` return the value of Column

3. ```GetField()``` return the Field name of Column

## Class **Row** 
Represent a Row in Database,each row has a list of Columns
Has Props of:
```C#
private List<Col> Columes {get;set;} = new List<Col> //each row carry a list of columns
```
And has a Constructor:
```C#
public Row(List<Col> cols){
Columes = cols;
}
public Row(){ //empty constructor}
```
The Row class have public actions
1. ```AddColume``` with diffrent parametes also check for repetition
- (**Col** col) 
- (**string** field,**object** value)
- (**Col** col,**int** index)
- (**string** field,**object** value,**int** index)
- defalut is adding to the end of the list

2. ```DeleteColume``` with diffrent parametes
- (**int** index) removing colume form row the index colume
- (**string** key) removing colume from row by colume name

3. ```GetColValue``` with diffrent parametes
- (**int** index) getting value based of index
- (**string** key) getting value based of colume name

4. ```UpdateColume``` with diffrent parametes
- (**Col** data,**Col** colume) updated colume by Colume name
- (**Col** data,**int** index) update colume by index
- (**List < Col >** new_data, **List < Col >** Columes) update multiple columes

## Condition
Represent a Conditions in a SQL Syntax Queries
Has props of:
```C#
  private Col Value { get; set; }//the Colume that we want condition, with the value we want to check
  private string Condition_Type { get; set; } = "=";//default condition is equal
```
Constructors:
 - (**Col** value)
 - (**string** field,**object** value)
 - (**string** field,**object** value,**string** condition)
 - The condition string can be only :
    - `=`
    - `!=`
    - `>`
    - `<`
    - `>=`
    - `<=`
    
## SQL_Queries

**It's a static class returning only sql queries strings**
### Constractors
 - **Has no Constractos**

### public static actions
1. `Insert` return's a sql insert string
  - (**string** table,**List < objects >** values)

2. `Delete` return a sql delete string
  - (**string** table,**Condtion** condition) delete a rows from table with 1 Condition
  - (**string** table, **List < Condition >** conditions,**string** Condition_Type)//deletes rows from table with Multi Condtions

3. `Update` return a sql update string
 - (**string** table,**List< Col>** Updated_Values,**Condition** Condition) updates rows  Cloumes by condition
 - (**string** table,**List< Col>** Updated_Values,**List< Condition<** Condition,**string** ConditionType) updates rows  Cloumes by multiple conditions

4. `Select` return a sql select string
  - (**string** table) return all rows from table
  - (**string** table,**List< string >** Columes) return all rows with specific columes
  - (**string** table,**Condition** Condition) return all rows with a condition
  - (**string** table , **List < Condition >** Conditions,**string** ConditionType) return rows by conditions
  - (**string** table,**List< string >** Columes,**List< Condition >** Conditions,**string** ConditionType) return rows with specific columes by conditions
  

 Condition_Type is the connector between multiple conditions and can be only:
 - `And`
 - `Or` 

# Getting Started
