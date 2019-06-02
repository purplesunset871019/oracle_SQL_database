create table TRADING_RECORD (COMMODITY_ID varchar2(3), PURCHASE_DATE date, manager_id number(3), COMPODITY_PURCHASES number(3), COMMODITY_SALES number(3), COMMODITY_INVENTORY varchar2(3), COMMODITY_EXP date);
create table EMPLOYEES (EMPLOYEE_ID varchar2(3), EMPLOYEE_NAME varchar2(20), WORKING_HOUR nvarchar2(11), EMAIL nvarchar2(20), PHONE_NUMBER varchar2(15), HIRE_DATE date, JOB_ID varchar2(3), MANAGER_ID varchar2(3));
create table PRODUCT_INFORMATION(COMMODITY_NAME nvarchar2(10),COMMODITY_ID varchar2(3),COMMODITY_PRICE number(6),COMMODITY_POSITION nvarchar2(10));
create table EMPLOYEE_SALARY(EMPLOYEE_ID varchar2(3),SALARY number(6),ANNUAL_BONUS number(6));
create table JOBS(JOB_ID varchar2(3),JOB_TITLE varchar2(10),MIN_SALARY number(6),MAX_SALARY number(6));
create table EMPLOYEE_HISTORY(EMPLOYEE_ID varchar2(3),START_DATE date,END_DATE date,JOB_ID varchar2(3));
create table FINANCIAL_STATEMENTS(TOTAL_SALARY number(7),UTILITIES_COST number(5),COMMODITY_COST number(7),COMMODITY_INCOME number(7),MISCELLANEOUS_COST number(5));
