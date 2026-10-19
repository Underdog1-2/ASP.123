# P_421_ASP

Учебный проект группы П-421: ASP.NET Core / Blazor.

Ссылки и TODO — см. [ReadMe.txt](ReadMe.txt).

## Структура

- `Blazor/Blazor.sln` — решение;
- `Blazor/Blazor/` — проект Blazor Web App (.NET 8, Interactive Server):
  - `Components/Pages/Counter.razor` — счётчик шагом (`@bind`);
  - `Components/Pages/Factorial.razor` + `.razor.cs` + `.razor.css` — факториал (`BigInteger`, CSS-изоляция, code-behind);
  - `Components/Pages/Power.razor` + `.razor.cs` + `.razor.css` — возведение в степень;
  - `Components/Pages/Fibonacci.razor` + `.razor.cs` — ряд Фибоначчи;
  - `Components/Layout/NavMenu.razor` — меню с пунктами и подменю "Crypto";
- `*.png` — скриншоты к лекциям (CSS и файловая изоляция компонентов).

## Запуск

```bash
cd Blazor
dotnet run --project Blazor
# http://localhost:5155
```
