### SQL_Generator
this are files that helps developer create there own sql queris without dealing with syntax
for this projects there are ***3*** basic classes that help build the SQL Queries:
  -Col
  -Row
  -condition

## Class **Col** 
Has props of
```
        private string Field {get;set;}//the field name of a colume
        private object Value {get;set;}//the value of the field (can be any value)
```
Class **Col** has constractor and actions that sets and gets the props above:
```
          //constractor
          public Col(string field, object value){
             Set(field, value);
            }

          //4 actions to set and get props
          public void Set(string field, object value){
             Field = field;
             Value = value;
              }
          public void Set(Col col){
             Field = col.GetField();
             Value = col.GetValue();
              }
          public object GetValue() {
             return Value;
              }
          public string GetField() {
             return Field;
              }
 ```
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
1. ```AddColume``` with 4 diffrent parametes also check for repetition
- (**Col** col) 
- (**string** field,**object** value)
- (**Col** col,**int** index)
- (**string** field,**object** value,**int** index)
  First two Actions adding Colume to the end of the List 
  Last two Actions adding Colume to an index based List
  
2. ```DeleteColume``` with 2 diffrent parametes
- (**int** index) removing colume form row the index colume
- (**string** key) removing colume from row by colume name
    
