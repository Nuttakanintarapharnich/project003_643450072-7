# project003_643450072-7
ความเป็นมาของโปรแกรม
```
เห็นว่ามีของหลายชนิดที่สามารถขายใด้จึงคิดโปรเเกรมที่สามารถเพิ่มได้อย่าอิสระ
```
วัตถุประสงค์ของโปรแกรม
```
อำนวยความสะดวกด้านการเพิ่มสินค้าเเละจัดการรายการที่ขายไปว่าขายไปได้เท่าไร

```
Class Diagram
```mermaid
classDiagram
 direction LR
 class form1{
  -name
  -price
  -quantity
  goform2()void
  add()void
  delete()void
  makelist()void
 }
class form2{
 -net amount
 -change
 -cash
 -date
 
 -ok()void
 
 }


 
 
 form2  --|> form1
```
เจ้าของโปรแกรม
```่่่่่นายณัฐกานต์ อินทรพานิชย์ 643450072-7```
