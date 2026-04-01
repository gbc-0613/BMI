# GitHub 推送步驟指南

本地 Git 倉庫已準備完成！現在需要推送到 GitHub。

## ?? 步驟說明

### 1. 在 GitHub 上創建新倉庫

1. 登入你的 GitHub 帳戶：https://github.com/login
2. 點擊右上角的 **+** 按鈕，選擇 **New repository**
3. 填寫倉庫信息：
   - **Repository name**：`bmi-calculator` 或 `bmi`
   - **Description**：`BMI Calculator - First class practice` 或 `第一次上課練習 - BMI計算器`
   - **Visibility**：選擇 **Public**（公開）或 **Private**（私人）
   - **Initialize this repository with**：不勾選（本地已有代碼）
4. 點擊 **Create repository**

### 2. 連接遠程倉庫並推送

創建完倉庫後，你會看到快速設置頁面，執行以下命令（根據你的倉庫名稱調整）：

```powershell
# 進入項目目錄
cd "C:\Users\user\Desktop\新增資料夾\BMI"

# 添加遠程倉庫（將 YOUR_USERNAME 和 YOUR_REPO_NAME 替換為你的信息）
git remote add origin https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git

# 將分支重命名為 main（GitHub 預設分支名）
git branch -M main

# 推送到 GitHub
git push -u origin main
```

### 3. 驗證推送成功

```powershell
# 查看遠程倉庫配置
git remote -v

# 輸出應該顯示：
# origin  https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git (fetch)
# origin  https://github.com/YOUR_USERNAME/YOUR_REPO_NAME.git (push)
```

## ?? 注意事項

- 首次推送時可能需要輸入 GitHub 認證信息
- 如果使用 2FA（雙因素認證），需要使用 Personal Access Token 代替密碼
- GitHub 已逐步廢棄密碼認證，建議使用 SSH 金鑰或 Personal Access Token

## ?? 使用 SSH 金鑰（推薦）

如果已配置 SSH 金鑰，使用以下命令：

```powershell
git remote add origin git@github.com:YOUR_USERNAME/YOUR_REPO_NAME.git
git branch -M main
git push -u origin main
```

## ?? 相關資源

- GitHub 官方文檔：https://docs.github.com/
- 生成 Personal Access Token：https://github.com/settings/tokens
- SSH 金鑰配置：https://docs.github.com/en/authentication/connecting-to-github-with-ssh

---

祝推送成功！??
