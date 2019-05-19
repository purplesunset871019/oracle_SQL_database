create table player_character (player_id varchar2(16),nickname varchar2(12),player_level number(2),Specialization_id number(2),weapen_id number(3),armor_id number(3));
select * from player_character;
insert into player_character values ('test001','test',1,0,1,1);

create table player_info (player_id varchar2(16),passward varchar2(16),email varchar2(50),tel varchar2(20));
create table specialization (spec_id number(2),spec_name varchar2(10),hp_weighted number(5,2),mp_weighted number(5,2),phy_damage_weighted number(5,2),magic_damage_weighted number(5,2),phy_defanse_weighted number(5,2),magic_defanse_weighted number(5,2),weapen_type_id number(4));
create table weapen_type (wid number(4),w_name varchar2(20),atk_weightd number(5,2));
create table weapen (w_item_id number(4),w_item_name varchar2(20),atk number(4));
create table armor (a_item_id number(4),a_item_name varchar2(20),pd_weighted number(5,2),md_weighted number(5,2),speed_weighted number(5,2),dodge_weighted number(5,2),hp_plus number(5),mp_plus number(5),durability number(3));
create table player_level (player_level number(3),hp_base number(5),mp_base number(5),pda_base number(5),mda_base number(5),pde_base number(4),mde_base number(4));
DROP TABLE player_level;