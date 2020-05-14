# Vibration-monitoring
## 一套震动监测系统，实现功能有用户管理，串口接收，Mysql存储，实时波形，历史报表


* **开发语言：C#**
* **UI界面：WinForm**
* **数据库：MySQL**

## 系统实现的功能有
* 串口通信
* 实时波形显示
* 数据库中存储数据
* 历史数据波形显示
* 历史数据报表显示
* 用户登录
* 用户分级管理

## 项目结构

### ConsoleApp1

开发过程中一些数据类型转换的测试，无项目引用关系

### 数据模拟发送

模拟下位机的串口数据发送的小程序

由于Windows操作系统的非实时性，数据发送间隔无法达到实际下位机的400us

### WindowsFormsControlLibrary1

自定义控件项目，图标在**icon**文件夹中，**震动监测系统**需引用此项目

### 震动监测系统

主体项目，需要引用**WindowsFormsControlLibrary1**项目

* controlconfig.cs
  * config文件操作类
  * 将串口参数保存至config文件中
* CTMySql.cs
  * MySQL数据库操作类
* CTSerialPort.cs
  * 串口操作类
* DrawWave.cs
  * 在PictureBox控件中绘制波形的类
* Form_SP_Set & Form_SP_Test
  * 串口参数设置 & 串口通信测试 界面
* Form1
  * 主窗口界面
* FormSaveWaiting
  * 存储数据时的进度条界面
* FormSignIn
  * 登录窗口界面
* FormWave
  * 实时波形显示界面
* FormHistoryData
  * 历史数据**波形显示**及**报表输出**界面
* FormUserManage
  * 用户管理界面
  
<p align = "right">2020年5月14日</p>
