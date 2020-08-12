### SQL_Generator
this are files that helps developer create there own sql queris without dealing with syntax
for this projects there are ***3*** basic classes that help build the SQL Queries:
  -Col
  -Row
  -condition

## Class **Col** 
*rep
Has props of
```C#
        private string Field {get;set;}//the field name of a colume
        private object Value {get;set;}//the value of the field (can be any value)
```

Constractors: 
- (**string** field, **object** value) create a new Colume with the data
- ***no empty contractor***

Class **Col** has public actions :

1. ```Set``` setting the colume data :
  - (**string** field, **object** value) 
  - (**Col** col)
  
2. ```GetValue()``` return the value of Colume

3. ```GetField()``` return the Field name of Colume

## Class **Row** 
Has Props of
```
private List<Col> Columes {get;set;} =new List<Col> //each row carry a list of columes
```
And has a Constractors:
```
public Row(List<Col> cols){
Columes = cols;
}
public Row(){ //empty constractor}
```
The Row class Have public actions
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



## SQL_Queries

**It's a static class returning only sql queries strings**
### Constractors
 - **Has no Constractos**

### public static actions
1. ```Insert``` return's a sql insert string
  - (**string** table,**List < objects >** values)
2. ```Delete``` return a sql delete string
  - 

