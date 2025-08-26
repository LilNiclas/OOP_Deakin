# Answers to Q3 and Q4

This document contains the answers for: 
- **Q3: Task 1.1.3 (Error Correction)**
- **Q4: Task 1.1.4 (Code Fragment Output)**

Variable names might differ, as I tested the examples within the same project (**number, number2, number3, etc.**)

---

## Q3: Task 1.1.3 – Error Correction

### 1. Example
**Original Issue:** Semicolon after the if statement.
```csharp
int number = 50;
if (number == 50)
{
    Console.WriteLine("Number is 50");
}
```

---

### 2. Example
**Original Issue:** Incorrect condition syntax (`and` instead of `&&`, wrong operators).
```csharp
int number2 = 60;
if (number2 >= 50 && number2 <= 100)
{
    Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100");
}
```

---

### 3. Example
**Original Issue:** Java-style class/method, missing parentheses, else with condition.
```csharp
double score = 40;
if (score > 40)
{
    Console.WriteLine("You passed the exam!");
}
else
{
    Console.WriteLine("You failed the exam!");
}
```

---

### 4. Example
**Original Issue:** `switch` should be lowercase, missing break, undefined variable.
```csharp
Console.WriteLine("Enter 1 or 2: ");
int number3 = Convert.ToInt32(Console.ReadLine());
switch (number3)
{
    case 1:
        Console.WriteLine("The number is 1");
        break;
    case 2:
        Console.WriteLine("The number is 2");
        break;
    default:
        Console.WriteLine("The number is not 1 or 2");
        break;
}
```

---

### 5. Example
**Original Issue:** `Case`/`Default` should be lowercase, missing space in `case2`, undefined variable.
```csharp
Console.WriteLine("Enter 1 or 2: ");
int number4 = Convert.ToInt32(Console.ReadLine());
switch (number4)
{
    case 1:
        Console.WriteLine("A");
        break;
    case 2:
        Console.WriteLine("B");
        break;
    default:
        Console.WriteLine("C");
        break;
}
```

---

## Q4: Task 1.1.4 – Code Fragment Output

### Example 1
**Original Output** proceed with caution.
**Original Issue:** No curly braces, only first line is part of if statement.
```csharp
int height = 13;
if (height <= 12)
{
    Console.WriteLine("Low bridge: Proceed with caution");
}
else
{
    Console.WriteLine("Height is safe");
}
```

---

### Example 2
**Original Output** You win the prize.
**Original Issue:** No curly braces after else, so only first line is part of else.
```csharp
int sum = 21;
if (sum != 20)
{
    Console.WriteLine("You win the prize");
}
else
{
    Console.WriteLine("You lose the prize");
}
```

---

### Example 3
**Original Output** You lose the prize.
**Original Issue:** Last line outside if/else, so always prints.
```csharp
int sum2 = 7;
if (sum2 > 20)
{
    Console.WriteLine("You win the prize");
}
else
{
    Console.WriteLine("You lose the prize");
}
```

---
