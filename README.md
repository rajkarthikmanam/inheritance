# USF Library Management System

## Team
- Karthik (books, Library base)
- Ananya (patrons, borrow flow)

## How to Run
```bash
cd OOP_Fall_2025_App
dotnet run

Then Stage → commit: `docs: update README with run steps` → Push.

### 4) Lock down `main` (optional but nice)
GitHub → **Settings → Branches → Add rule**
- Pattern: `main`
- ✅ Require pull request before merging (Approvals: 1)
- ✅ Require branches to be up to date (optional)
- ✅ Dismiss stale approvals (optional)
- (Optional) ✅ Include administrators

### 5) Final submission checklist
- [x] Code compiles/runs with `dotnet run` inside `OOP_Fall_2025_App/`
- [x] `output.png` is **in the root** and **pushed to main**
- [x] README has run steps and team names
- [x] Repo link ready — submit the **GitHub repo URL**

---

### Want a tiny “extra polish” (only if you have 2–3 mins)?
- In `Library.Borrow(...)`, return a clearer message when ISBN/patron not found (you already do this ✅).
- Add a `ReturnBook()` demo (just one line after borrowing) to show both flows:
  ```csharp
  b2.ReturnBook(); // optional demo
