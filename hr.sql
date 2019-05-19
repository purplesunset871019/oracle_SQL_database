SELECT * FROM EMPLOYEES;
--Exercise 1-1
SELECT * FROM EMPLOYEES WHERE EMPLOYEE_ID=200;
select hire_date, salary from EMPLOYEES where EMPLOYEE_ID=200;
--Exercise 1-2
select first_name, salary, salary*1.5 "年終" from employees;
SELECT * FROM EMPLOYEES WHERE MANAGER_ID is null;
--Exercise 1-3
select first_name||'的主管編號是'||manager_id from employees;
select job_id FROM employees;
--Exercise 2-1
select first_name from employees where hire_date >= '01-1月-02' and hire_date <='31-12月-02';
select first_name from employees where hire_date BETWEEN '01-1月-02' and '31-12月-02';
select first_name from employees where hire_date like '%02';
--Exercise 2-2
select * from employees order by salary desc, hire_date;
--Exercise 3-1
select department_id, LPAD(department_id,5,0) from DEPARTMENTS;
--Exercise 3-2
select first_name, substr(first_name,instr(first_name,'un'),3)from employees where instr(first_name,'un')<>0;
--Exercise 3-3
select employee_id, first_name from employees where MOD(employee_id,2)=0 order by employee_id;
--Exercise 3-4
select first_name from employees where months_between(SYSDATE,hire_date)>180;
select hire_date, ADD_MONTHS(TRUNC(ADD_MONTHs(hire_date,3),'MONTH')+5,1) from employees;
--Exercise 3-5
select substr(job_title,instr(job_title,' ',-1)+1) from JOBS;
--Exercise 4-1
SELECT * FROM employees WHERE hire_date = TO_DATE('20070621', 'YYYYMMDD');
SELECT TO_CHAR(hire_date, 'YYYYMMDD') FROM employees WHERE hire_date = TO_DATE('20070621', 'YYYYMMDD');
--Exercise 4-2
select manager_id, NVL2(manager_id,first_name||'是員工',first_name||'是總經理') from EMPLOYEES;
--Exercise 4-3
select last_name, TO_CHAR(hire_date,'YYYYMM'), 
(case when to_char(hire_date,'MM')<03 then to_char(hire_date,'YYYY')-1911-1||'-1'
     when to_char(hire_date,'MM')<08 then to_char(hire_date,'YYYY')-1911-1||'-2'
     else to_char(hire_date,'YYYY')-1911||'-1'
     END) AA
     from employees;
--Exercise 4-4
select last_name,hire_date,
DECODE(to_char(hire_date,'MM'),01,to_char(hire_date,'YY')||'年第一季',
                               02,to_char(hire_date,'YY')||'年第一季',
                               03,to_char(hire_date,'YY')||'年第一季',
                               04,to_char(hire_date,'YY')||'年第二季',
                               05,to_char(hire_date,'YY')||'年第二季',
                               06,to_char(hire_date,'YY')||'年第二季',
                               07,to_char(hire_date,'YY')||'年第三季',
                               08,to_char(hire_date,'YY')||'年第三季',
                               09,to_char(hire_date,'YY')||'年第三季',
                               10,to_char(hire_date,'YY')||'年第四季',
                               11,to_char(hire_date,'YY')||'年第四季',
                               12,to_char(hire_date,'YY')||'年第四季') AA西元年,
DECODE(to_char(hire_date,'MM'),01,to_char(hire_date,'YYYY')-1911||'年第一季',
                               02,to_char(hire_date,'YYYY')-1911||'年第一季',
                               03,to_char(hire_date,'YYYY')-1911||'年第一季',
                               04,to_char(hire_date,'YYYY')-1911||'年第二季',
                               05,to_char(hire_date,'YYYY')-1911||'年第二季',
                               06,to_char(hire_date,'YYYY')-1911||'年第二季',
                               07,to_char(hire_date,'YYYY')-1911||'年第三季',
                               08,to_char(hire_date,'YYYY')-1911||'年第三季',
                               09,to_char(hire_date,'YYYY')-1911||'年第三季',
                               10,to_char(hire_date,'YYYY')-1911||'年第四季',
                               11,to_char(hire_date,'YYYY')-1911||'年第四季',
                               12,to_char(hire_date,'YYYY')-1911||'年第四季') AA民國年
from employees;
--Exercise 4-4

--Exercise 5-1
select department_id, count(*) from employees group by department_id having count(*)>5 order by count(*);
--Exercise 6-1
select department_id, department_name, manager_id, location_id, city from departments natural join locations order by department_id;
select d.department_id, d.department_name, d.manager_id, location_id, l.city from departments d join locations l using (location_id) order by d.department_id;
select d.department_id, d.department_name, d.manager_id, l.location_id, l.city from departments d join locations l on (d.location_id = l.LOCATION_ID) order by d.department_id;
--Exercise 6-2
select d.department_id, c.country_name from departments d join locations l using (location_id) join countries c using (country_id);
--Exercise 6-3
select department_id, d.department_name, count(e.employee_id) from departments d join employees e using (department_id) group by d.department_name, department_id having count(e.employee_id)>5 order by department_id;
--Exercise 6-4
select a.employee_id, a.last_name,a.department_id,b.employee_id,b.last_name,b.department_id from employees a join employees b on(a.department_id=b.department_id) where a.employee_id <> b.employee_id and a.employee_id=100;
--Exercise 6-5
SELECT e.last_name, e.salary, j.highest_sal
FROM employees e JOIN job_grades j
ON e.salary
BETWEEN j.lowest_sal AND j.highest_sal;
--------------------------------------------------------------------------------
create table user_info(user_id int, user_name VARCHAR2(20)) ;
create table user_login_log(user_id int, login_time DATE) ;

insert into user_info values('0001','a0001');
insert into user_info values('0002','a0002');
insert into user_info values('0003','a0003');
insert into user_info values('0004','a0004');
insert into user_info values('0005','a0005');

insert into user_login_log values('0001',to_date('20140101','YYYYMMDD'));
insert into user_login_log values('0001',to_date('20140102','YYYYMMDD'));
insert into user_login_log values('0002',to_date('20140101','YYYYMMDD'));
insert into user_login_log values('0002',to_date('20140102','YYYYMMDD'));
insert into user_login_log values('0002',to_date('20140103','YYYYMMDD'));
insert into user_login_log values('0002',to_date('20140104','YYYYMMDD'));
