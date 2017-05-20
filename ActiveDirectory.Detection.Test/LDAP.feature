Feature: LDAP
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: 取得LDAP
	Given 我有以下AD資料
	When 我調用 Extension
	Then AD狀態的結果會全部變成(False)
