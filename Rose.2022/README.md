# Advent of Code 2022 - Azure functions

The goal of this year Advent of Code is to familiarize myself with Azure Functions.

How to call local Azure function.

``` 
curl -X POST --location "http://localhost:7071/api/Day1HttpTrigger" \
-H "Content-Type: application/text" \
-d "3344
8938
7923
3979
2753
5730
4225

24216
7432
18284

3475
9177
6769
11335
8061
9302
8132

...
"
```
