--INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender) VALUES
--('John', 'Doe', '1980-05-15', 'Male'),
--( 'Jane', 'Smith', '1992-11-23', 'Female'),
--( 'Robert', 'Johnson', '1975-09-30', 'Male'),
--( 'Emily', 'Davis', '1988-07-12', 'Female'),
--( 'Michael', 'Brown', '2000-01-05', 'Male');

--INSERT INTO Doctors (FirstName, LastName, Specialty) VALUES
--('James', 'Williams', 'Cardiologist'),
--('Mary', 'Jones', 'Neurologist'),
--('William', 'Garcia', 'Orthopedist'),
--('Linda', 'Martinez', 'Pediatrician'),
--('Richard', 'Rodriguez', 'Surgeon');

--INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Diagnosis) VALUES
--( 1, 1, '2024-06-15', 'Hypertension'),
--( 2, 2, '2024-06-16', 'Migraine'),
--( 3, 3, '2024-06-17', 'Bone Fracture'),
--( 4, 4, '2024-06-18', 'Childhood Illness'),
--( 5, 5, '2024-06-19', 'Appendicitis');


--alter table Doctors add Staj int 
 
select concat(p.FirstName,'-',p.LastName)as Patients,CONCAT(d.FirstName,'-',d.LastName) as Doctors from Appointments a 
join Doctors d on a.DoctorId = d.id 
join Patients p on a.PatientID = p.Id


select * from Doctors where Staj > 10

Select * from Patients order by FirstName , LastName desc ;

select * from Doctors where Staj>3 and Staj<6 order by Staj desc




