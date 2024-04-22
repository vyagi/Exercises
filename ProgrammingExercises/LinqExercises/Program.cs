using LinqExercises;

var employees = Employee.GetEmployees().ToList();

var personalData = PersonalData.GetPersonalData().ToList();

//tasks to do:

/*
1. Select employees with seniority greater than 8 years
2. Select women employees
3. Find the average salary
4. Select employees who earn above the average
5. Select employees with bonus greater than 10% of their salary
6. Find the sum of salaries paid for men employees
7. Find a woman with the highest seniority
8. Find the sum of bonus for all the employees on their notice period
9. Find the total tax (13%) which you must add to the salaries
10. Select employees in their thirties
11. Find the intern who works the longest
12. How much to the intern workers earn in total
13. What is the average age
14. Find those who are younger than the average
15. Find those whose name is longer than lastname
16. How many women interns are there
17. How many women are on their notice period
18. What is the average salary for all the regular workers and those on their notice period
19. Who lives where
20. Who was born on which day (like: John Kowalski was born 10 December 1965)
21. From which city are the most employees
22. Group the workers by their cities
23. What is the average age of employees from Krakow
24. Who lives in a house (most probably)
25. Who was born in February
*/