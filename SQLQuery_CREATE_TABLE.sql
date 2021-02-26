CREATE TABLE doctors(
doctor_id int identity(1,1) primary key,
firstname varchar (30),
lastname varchar (30),
date_of_employment date not null,
date_of_release date);

CREATE TABLE patients(
patient_id int identity(1,1) primary key,
firstname varchar (30),
lastname varchar (30),
date_of_admission date not null,
date_of_discharge date);

CREATE TABLE visits(
visit_id int identity(1,1) primary key,
doctor_id int foreign key references doctors(doctor_id) not null,
patient_id int foreign key references patients(patient_id) not null,
date_of_visit date not null);

CREATE TABLE diagnosis(
diagnosis_id int identity(1,1) primary key,
visit_id int foreign key references visits(visit_id) not null,
illness_name varchar(30),
description varchar(150));
