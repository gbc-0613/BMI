# 推送到 GitHub

## 快速步驟

### 步驟 1: 在 GitHub 上創建倉庫

1. 打開瀏覽器：https://github.com/new
2. 填寫信息：
   - **Repository name**：`bmi`
   - **Description**：`BMI 計算器 - 第一次上課練習`
   - **Visibility**：Public（公開）
   - **Initialize**：不勾選
3. 點擊「Create repository」

### 步驟 2: 在 PowerShell 中運行

```powershell
cd "C:\Users\user\Desktop\新增資料夾\BMI"

git remote add origin https://github.com/你的用?名/bmi.git

git branch -M main

git push -u origin main
```

### 步驟 3: 輸入認證

輸入你的 GitHub 用?名和 Personal Access Token（在 GitHub Settings > Tokens 中生成）。

---

完成後訪問：`https://github.com/你的用?名/bmi`
