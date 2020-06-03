#Given == Pre-requisite
#When == Actions
#Then == ExpectedOutcome(ExpectedResult)

Feature: ShortTermLoans

Scenario: LoanApplication_01_Verify that a user can apply for £350 loan amount successfully
	Given auden group short tem loan page is fully loaded
	When a user selects £350 loan amount
	Then £350 loan amount should be selected and displayed successfully

Scenario: LoanApplication_02_Verify that a user can not select a weekend date successfully
	Given auden group short tem loan page is fully loaded
	When a user selects a weekend date like Saturday 6 Jun 2020
	Then Friday 5 Jun 2020 should be displayed successfully

Scenario: AboutUs_01_Verify that a user can navigate to about us page successfully
	Given auden group short tem loan page is fully loaded
	When a user clicks on the about us link
	Then a user should navigate to about us page successfully

Scenario: FAQs_01_Verify that a user can navigate to FAQs page successfully
	Given auden group short tem loan page is fully loaded
	When a user clicks on the FAQs link
	Then a user should navigate to FAQs page successfully