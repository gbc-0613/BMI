# GitHub 推送腳本
# 使用方法: .\push_to_github.ps1

Write-Host "================================" -ForegroundColor Green
Write-Host "BMI Calculator - GitHub 推送工具" -ForegroundColor Green
Write-Host "================================" -ForegroundColor Green
Write-Host ""

# 獲取用?輸入
$githubUsername = Read-Host "請輸入你的 GitHub 用?名"
$repositoryName = Read-Host "請輸入倉庫名稱 (預設: bmi)" 
if ([string]::IsNullOrWhiteSpace($repositoryName)) {
    $repositoryName = "bmi"
}

$repositoryUrl = "https://github.com/$githubUsername/$repositoryName.git"

Write-Host ""
Write-Host "倉庫信息:" -ForegroundColor Cyan
Write-Host "  用?名: $githubUsername"
Write-Host "  倉庫名: $repositoryName"
Write-Host "  URL: $repositoryUrl"
Write-Host ""

# 確認信息
$confirm = Read-Host "確認信息是否正確? (Y/N)"
if ($confirm -ne "Y" -and $confirm -ne "y") {
    Write-Host "已取消推送" -ForegroundColor Red
    exit
}

Write-Host ""
Write-Host "正在推送到 GitHub..." -ForegroundColor Yellow

try {
    # 進入項目目錄
    cd "C:\Users\user\Desktop\新增資料夾\BMI"
    
    # 添加遠程倉庫
    Write-Host "1. 添加遠程倉庫..." -ForegroundColor Cyan
    git remote add origin $repositoryUrl
    
    # 將分支重命名為 main
    Write-Host "2. 重命名分支為 main..." -ForegroundColor Cyan
    git branch -M main
    
    # 推送到 GitHub
    Write-Host "3. 推送代碼到 GitHub..." -ForegroundColor Cyan
    Write-Host "   (請在彈出的登入視窗中輸入 GitHub 認證信息)" -ForegroundColor Yellow
    git push -u origin main
    
    Write-Host ""
    Write-Host "================================" -ForegroundColor Green
    Write-Host "? 推送成功!" -ForegroundColor Green
    Write-Host "================================" -ForegroundColor Green
    Write-Host ""
    Write-Host "你的倉庫已發佈到:" -ForegroundColor Cyan
    Write-Host "  $repositoryUrl" -ForegroundColor White
    Write-Host ""
    Write-Host "在線查看: https://github.com/$githubUsername/$repositoryName" -ForegroundColor Cyan
}
catch {
    Write-Host ""
    Write-Host "? 推送失敗!" -ForegroundColor Red
    Write-Host "錯誤信息: $_" -ForegroundColor Red
    Write-Host ""
    Write-Host "可能的原因:" -ForegroundColor Yellow
    Write-Host "  1. 尚未在 GitHub 創建倉庫"
    Write-Host "  2. GitHub 認證失敗（需要 Personal Access Token 或 SSH 金鑰）"
    Write-Host "  3. 倉庫名稱或用?名不正確"
    Write-Host ""
    Write-Host "解決方案:" -ForegroundColor Cyan
    Write-Host "  1. 先在 https://github.com/new 創建倉庫"
    Write-Host "  2. 確保已配置 GitHub 認證（推薦使用 Personal Access Token）"
    Write-Host "  3. 重新運行此腳本"
}

Read-Host "按 Enter 鍵關閉此視窗"
