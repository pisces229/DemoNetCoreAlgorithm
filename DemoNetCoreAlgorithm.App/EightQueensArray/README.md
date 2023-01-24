
## Exact enumeration

|n|1|2|3|4| 5|6| 7| 8|  9| 10|  11|   12|   13|    14|
|U|1|0|0|1| 2|1| 6|12| 46| 92| 341| 1787| 9233| 45752|
|D|1|0|0|2|10|4|40|92|352|724|2680|14200|73712|365596|

## Rotation matrix

[0](https://youtu.be/xY6qOHBf1as)

## counterclockwise 

```
( x , y )

| x | | cos90° -sin90° | | x' |
|   |*|                |=|    |
| y | | sin90°  cos90° | | y' |

cos90° = 0
sin90° = 1

x' = x*(cos90°) + y*(-sin90°)
y' = x*(sin90°) + y*( cos90°)

x' = x*(0) + y*(-1)
y' = x*(1) + y*( 0)

( x' + count , y' )
```

## clockwise 

```
( x , y )

| x | | cos270° -sin270° | | x' |
|   |*|                  |=|    |
| y | | sin270°  cos270° | | y' |

cos270° = 0
sin270° = -1

x' = x*(cos270°) + y*(-sin270°)
y' = x*(sin270°) + y*( cos270°)

x' = x*( 0) + y*(1)
y' = x*(-1) + y*(0)

( x' , y' + count )
```
