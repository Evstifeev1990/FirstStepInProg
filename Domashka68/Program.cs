//реализация функции Аккермана Command+C и Comand+v очень сложно((((()))))
tatic uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.WriteLine(A(2,2));