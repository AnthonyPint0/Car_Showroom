CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Address VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20),
    Username VARCHAR(50) UNIQUE NOT NULL,  -- New field for username
    Password VARCHAR(100) NOT NULL,        -- New field for password
    RegistrationDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE Cars(
    CarId VARCHAR(50) PRIMARY KEY,
    CarName VARCHAR(100) NOT NULL,
    Engine VARCHAR(50),
    Mileage VARCHAR(50),
    Transmission VARCHAR(50),
    FuelType VARCHAR(50),
    MaxPower VARCHAR(50),
    SeatingCapacity VARCHAR(50),
	DriverType VARCHAR(50),
    BodyType VARCHAR(50),
    Description TEXT,
    Price INT,
    CustReview DECIMAL(3, 1),
    CustReviewLink VARCHAR(255)
);


DELETE FROM CarColors WHERE CarId = 'HarrierC1'
DELETE FROM InventoryStatus WHERE CarId = 'HarrierC1'
DELETE FROM Cars WHERE CarId = 'HarrierC1'


INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('BalenoC1', 'Maruti Suzuki Baleno', '1197 CC', '22.35 - 22.94 Kmpl', 'Manual / Automatic', 'Petrol / CNG', '88.50bhp@6000rpm', '5','FWD', 'Hatchback', 'Maruti Baleno is a 5 seater hatchback car in a price range of Rs. 6.66 Lakh to 9.88 Lakh in India. Baleno is offered with 1.2L petrol engine in both manual and automatic transmission. Maruti Baleno gives a mileage of 22.94 kmpl on petrol. The boot space of the Baleno is 318 litres. It is available in 9 variants and 7 beautiful colours. Considering the price and specs the Baleno is a tough competition to Hyundai Exter, Hyundai i20 and Tata Altroz.', 850000, 4.3, 'https://www.zigwheels.com/user-reviews/maruti-suzuki/baleno');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('PunchC1', 'Tata Punch', '1199 CC', '18.8 Kmpl - 26.99 Km/Kg', 'Manual / Automatic', 'Petrol / CNG', '86.63bhp@6000rpm', '5','FWD', 'Hatchback', 'Tata Punch is a 5 seater Hatchback car in a price range of Rs. 6.12 Lakh to 10.19 Lakh in India with 5 star safety rating. Punch is offered with 1.2L petrol engine with CNG option in both manual and automatic transmission. Tata Punch gives a mileage of 18.8 Kmpl on petrol and 26.99 km/kg on CNG. The boot space of the Punch is 366 litres while its ground clearance is 187 mm. It is available in 25 variants and 8 beautiful colours. Considering the price and specs the Punch is a tough competition to Hyundai Exter, Maruti FRONX and Maruti Swift.', 800000, 4.4, 'https://www.zigwheels.com/user-reviews/tata/punch');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('WagonRC1', 'Maruti Suzuki WagonR', '1197 cc', '24.43 kmpl', 'Manual / Automatic', 'Petrol / CNG', '88.50bhp@6000rpm', '5', 'FWD', 'Hatchback', 'Maruti Suzuki WagonR is a 5 seater Hatchback car available in a price range of Rs. 5.45 Lakh to 9.05 Lakh in India. It is powered by a 998 cc engine which is available with a Manual and Automatic transmission. Depending upon the variant and fuel type the WagonR has a mileage of 20.52 km/l. The WagonR has a boot space of 341 litres while its ground clearance is 170 mm. It is available in 14 variants and 6 colours. The WagonR is a perfect family car with its compact dimensions, good fuel efficiency, and spacious cabin.', 725000, 4.3, 'https://www.cardekho.com/maruti/wagon-r/user-reviews');

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('SwiftC1', 'Maruti Suzuki Swift', '1197 CC', '22.38 Kmpl - 30.9 Km/Kg', 'Manual / Automatic', 'Petrol / CNG / Diesel', '88.50bhp@6000rpm', '5','FWD', 'Hatchback', 'Maruti Swift is a 5 seater hatchback car in a price range of Rs. 5.99 Lakh to 9.03 Lakh in India with 1 star safety rating. Swift is offered with 1.2L petrol engine with CNG option in both manual and automatic transmission. Maruti Swift gives a mileage of 22.38 Kmpl on petrol and 30.9 km/kg on CNG. It is available in 11 variants and 10 beautiful colours. Considering the price and specs the Swift is a tough competition to Hyundai Exter, Tata Altroz and Tata Punch.', 750000, 4.1, 'https://www.zigwheels.com/user-reviews/maruti-suzuki/swift');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('i10_NiosC1', 'Hyundai Grand i10 Nios', '1197 CC', '16 Kmpl - 27 Km/Kg', 'Manual / Automatic', 'Petrol / CNG / Diesel', '81.80bhp@6000rpm', '5','FWD', 'Hatchback', 'Hyundai Grand i10 Nios is a 5 seater hatchback car in a price range of Rs. 5.92 Lakh to 8.56 Lakh in India. Grand i10 Nios is offered with 1.2L petrol engine with CNG option in both manual and automatic transmission. Hyundai Grand i10 Nios gives a mileage of 16 Kmpl on petrol and 27 km/kg on CNG. It is available in 12 variants and 8 beautiful colours. Considering the price and specs the Grand i10 Nios is a tough competition to Maruti Baleno, Maruti Ignis and Maruti Swift.', 775000, 4.5, 'https://www.zigwheels.com/user-reviews/hyundai/grand-i10-nios');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('KwidC1', 'Renault Kwid', '999 CC', '21.46 - 22.3 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '67.06bhp@5500rpm', '5','FWD', 'Hatchback', 'Renault KWID is a 5 seater hatchback car in a price range of Rs. 4.69 Lakh to 6.44 Lakh in India. KWID is offered with 1L petrol engine in both manual and automatic transmission. Renault KWID gives a mileage of 22.3 kmpl on petrol. The boot space of the KWID is 279 litres while its ground clearance is 184 mm. It is available in 9 variants and 7 beautiful colours. Considering the price and specs the KWID is a tough competition to Maruti Alto K10, Maruti Celerio and Maruti S-Presso.', 550000, 3.8, 'https://www.zigwheels.com/user-reviews/renault/kwid');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('DzireC1', 'Maruti Suzuki Dzire', '1197 CC', '22.41 Kmpl - 31.12 Km/Kg', 'Manual / Automatic', 'Petrol / CNG / Diesel', '88.50bhp@6000rpm', '5','FWD', 'Sedan', 'Maruti Dzire is a 5 seater sedan car in a price range of Rs. 6.51 Lakh to 9.38 Lakh in India. Dzire is offered with 1.2L petrol engine with CNG option in both manual and automatic transmission. Maruti Dzire gives a mileage of 22.41 Kmpl on petrol and 31.12 km/kg on CNG. The boot space of the Dzire is 378 litres while its ground clearance is 160 mm. It is available in 9 variants and 7 beautiful colours. Considering the price and specs the Dzire is a tough competition to Honda Amaze, Hyundai Aura and Tata Punch.', 800000, 4.0, 'https://www.zigwheels.com/user-reviews/maruti-suzuki/swift-dzire');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('AmazeC1', 'Honda Amaze', '1199 CC', '18.3 - 18.6 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '88.50bhp@6000rpm', '5','FWD', 'Sedan', 'Honda Amaze is a 5 seater sedan car in a price range of Rs. 7.15 Lakh to 9.91 Lakh in India. Amaze is offered with 1.2L petrol engine in both manual and automatic transmission. Honda Amaze gives a mileage of 18.6 kmpl on petrol. It is available in 7 variants and 6 beautiful colours. Considering the price and specs the Amaze is a tough competition to Hyundai Aura, Maruti Baleno and Maruti Ciaz.', 850000, 4.2, 'https://www.zigwheels.com/user-reviews/honda/amaze');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('AuraC1', 'Hyundai Aura', '1197 CC', '17 Kmpl - 22 Km/Kg', 'Manual / Automatic', 'Petrol / CNG / Diesel', '67.72bhp@6000rpm', '5','FWD', 'Sedan', 'Hyundai Aura is a 5 seater sedan car in a price range of Rs. 6.48 Lakh to 9.04 Lakh in India. Aura is offered with 1.2L petrol engine with CNG option in both manual and automatic transmission. Hyundai Aura gives a mileage of 17 Kmpl on petrol and 22 km/kg on CNG. It is available in 7 variants and 6 beautiful colours. Considering the price and specs the Aura is a tough competition to Honda Amaze, Maruti Baleno and Maruti Dzire.', 800000, 4.2, 'https://www.zigwheels.com/user-reviews/hyundai/aura');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('CiazC1', 'Maruti Suzuki Ciaz', '1462 CC', '20.04 - 20.65 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '103.25bhp@6000rpm', '5','FWD', 'Sedan', 'Maruti Ciaz is a 5 seater sedan car in a price range of Rs. 9.40 Lakh to 12.29 Lakh in India. Ciaz is offered with 1.5L petrol engine in both manual and automatic transmission. Maruti Ciaz gives a mileage of 20.65 kmpl on petrol. The boot space of the Ciaz is 510 litres. It is available in 7 variants and 10 beautiful colours. Considering the price and specs the Ciaz is a tough competition to Honda Amaze, Honda City and Hyundai Verna.', 1050000, 4.3, 'https://www.zigwheels.com/user-reviews/maruti-suzuki/ciaz');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('Tata Tigor', 'Tata Tigor', '1199 CC', '19.28 Kmpl - 26.49 Km/Kg', 'Manual / Automatic', 'Petrol / CNG / Diesel', '72.41bhp@6000rpm', '5','FWD', 'Sedan', 'Tata Tigor is a 5 seater sedan car in a price range of Rs. 6.29 Lakh to 9.54 Lakh in India. Tigor is offered with 1.2L petrol engine with CNG option in both manual and automatic transmission. Tata Tigor gives a mileage of 19.28 Kmpl on petrol and 26.49 km/kg on CNG. The boot space of the Tigor is 205 litres while its ground clearance is 165 mm. It is available in 11 variants and 5 beautiful colours. Considering the price and specs the Tigor is a tough competition to Honda Amaze, Hyundai Aura and Maruti Dzire.', 775000, 4.3, 'https://www.zigwheels.com/user-reviews/tata/tigor');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('VernaC1', 'Hyundai Verna', '1482 - 1497 CC', '18.6 - 20.6 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '157.57bhp@5500rpm', '5','FWD', 'Sedan', 'Hyundai Verna is a 5 seater sedan car in a price range of Rs. 11.00 Lakh to 17.41 Lakh in India with 5 star safety rating. Verna is offered with 1.5L petrol engine in both manual and automatic transmission. Hyundai Verna gives a mileage of 20.6 kmpl on petrol. The boot space of the Verna is 528 litres. It is available in 14 variants and 9 beautiful colours. Considering the price and specs the Verna is a tough competition to Honda City, Kia Sonet and Maruti Ciaz.', 1400000, 4.3, 'https://www.zigwheels.com/user-reviews/hyundai/verna');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('BrezzaC1', 'Maruti Suzuki Brezza', '1462 CC', '17.38 Kmpl - 25.51 Km/Kg', 'Manual / Automatic', 'Petrol / CNG / Diesel', '101.64bhp@6000rpm', '5','FWD', 'SUV', 'Maruti Brezza is a 5 seater SUV car in a price range of Rs. 8.29 Lakh to 14.14 Lakh in India. Brezza is offered with 1.5L petrol engine with CNG option in both manual and automatic transmission. Maruti Brezza gives a mileage of 17.38 Kmpl on petrol and 25.51 km/kg on CNG. The ground clearance of Brezza is 198 mm. It is available in 15 variants and 10 beautiful colours. Considering the price and specs the Brezza is a tough competition to Hyundai Creta, Hyundai Venue and Kia Sonet.', 1050000, 4.2, 'https://www.zigwheels.com/user-reviews/maruti-suzuki/brezza');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('NexonC1', 'Tata Nexon', '1199 - 1497 CC', '17.01 - 24.08 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '113.31bhp@3750rpm', '5','FWD', 'SUV', 'Tata Nexon is a 5 seater SUV car in a price range of Rs. 8.14 Lakh to 15.59 Lakh in India. Nexon is offered with 1.5L diesel engine and 1.2L petrol engines in both manual and automatic transmission. Tata Nexon gives a mileage of 17.01 Kmpl on petrol and 24.08 Kmpl on diesel. The boot space of the Nexon is 382 litres while its ground clearance is 208 mm. It is available in 69 variants and 9 beautiful colours. Considering the price and specs the Nexon is a tough competition to Hyundai Creta, Hyundai Venue and Kia Sonet.', 1200000, 4.6, 'https://www.zigwheels.com/user-reviews/tata/nexon');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('CretaC1', 'Hyundai Creta', '1482 - 1497 CC', '17.7 - 21.8 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '157.57bhp@5500rpm', '5','FWD', 'SUV', 'Hyundai Creta is a 5 seater SUV car in a price range of Rs. 10.99 Lakh to 20.14 Lakh in India. Creta is offered with 1.5L diesel engine and 1.5L petrol engines in both manual and automatic transmission. Hyundai Creta gives a mileage of 17.4 Kmpl on petrol and 21.8 Kmpl on diesel. The ground clearance of Creta is 190 mm. It is available in 28 variants and 7 beautiful colours. Considering the price and specs the Creta is a tough competition to Honda Elevate, Kia Seltos and Maruti Brezza.', 1550000, 4.5, 'https://www.zigwheels.com/user-reviews/hyundai/creta');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('SeltosC1', 'Kia Seltos', '1482 - 1497 CC', '17.9 - 20.7 Kmpl', 'Automatic / Manual', 'Petrol / Diesel', '114.41bhp@4000rpm', '5','FWD', 'SUV', 'Kia Seltos is a 5 seater SUV car in a price range of Rs. 10.89 Lakh to 20.29 Lakh in India. Seltos is offered with 1.5L and diesel engine and 1.5L petrol engines in both manual and automatic transmission. Kia Seltos gives a mileage of 17 Kmpl on petrol and 20.7 Kmpl on diesel. The boot space of the Seltos is 433 litres. It is available in 27 variants and 9 beautiful colours. Considering the price and specs the Seltos is a tough competition to Honda Elevate, Hyundai Creta and Maruti Grand Vitara.', 1575000, 4.6, 'https://www.zigwheels.com/user-reviews/kia/seltos');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('XUV300C1', 'Mahindra XUV300', '1197 - 1497 CC', '16.5 - 20.1 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '115.05bhp@3750rpm', '5','FWD', 'SUV', 'Mahindra XUV300 is a 5 seater SUV car in a price range of Rs. 7.99 Lakh to 14.75 Lakh in India. XUV300 is offered with 1.5L diesel engine and 1.2L petrol engines in both manual and automatic transmission. Mahindra XUV300 gives a mileage of 16.5 Kmpl on petrol and 20.1 Kmpl on diesel. It is available in 25 variants and 11 beautiful colours. Considering the price and specs the XUV300 is a tough competition to Hyundai Creta, Hyundai Venue and Kia Sonet.', 1060000, 4.3, 'https://www.zigwheels.com/user-reviews/mahindra/xuv300');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('MagniteC1', 'Nissan Magnite', '999 CC', '17.4 - 20 Kmpl', 'Manual / Automatic', 'Petrol / Diesel', '98.63bhp@5000rpm', '5','FWD', 'SUV', 'Nissan Magnite is a 5 seater SUV car in a price range of Rs. 5.99 Lakh to 11.27 Lakh in India. Magnite is offered with 1L petrol engine in both manual and automatic transmission. Nissan Magnite gives a mileage of 20 kmpl on petrol. The boot space of the Magnite is 336 litres while its ground clearance is 205 mm. It is available in 32 variants and 9 beautiful colours. Considering the price and specs the Magnite is a tough competition to Hyundai Exter, Kia Sonet and Maruti Brezza.', 800000, 4.2, 'https://www.zigwheels.com/user-reviews/nissan/magnite');

--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('BoleroC1', 'Mahindra Bolero', '1493 CC', '16 Kmpl', 'Manual', 'Petrol / Diesel', '74.96bhp@3600rpm', '7','RWD', 'MUV', 'Mahindra Bolero is a 7 seater SUV car in a price range of Rs. 9.89 Lakh to 10.90 Lakh in India. Bolero is offered with 1.5L diesel engine in manual transmission option only. Mahindra Bolero gives a mileage of 16 kmpl on diesel. The ground clearance of Bolero is 180 mm. It is available in 3 variants and 3 beautiful colours. Considering the price and specs the Bolero is a tough competition to Maruti Ertiga.', 1020000, 4.0, 'https://www.zigwheels.com/user-reviews/mahindra/bolero');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('InnovaC1', 'Toyota Innova Crysta', '2393 CC', '12 kmpl', 'Manual', 'Petrol / Diesel', '147.51bhp@3400rpm', '7','RWD', 'MUV', 'Toyota Innova Crysta is a 8 seater MUV car in a price range of Rs. 19.99 Lakh to 26.30 Lakh in India. Innova Crysta is offered with 2.4L diesel engine in manual transmission option only. The boot space of the Innova Crysta is 300 litres. It is available in 7 variants and 5 beautiful colours. Considering the price and specs the Innova Crysta is a tough competition to Hyundai Alcazar, Mahindra Scorpio N and Mahindra XUV700.', 2150000, 4.5, 'https://www.zigwheels.com/user-reviews/toyota/innova-crysta');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('ErtigaC1', 'Maruti Suzuki Ertiga', '1462 CC', '20.3 Kmpl - 26.11 Km/Kg', 'Automatic / Manual', 'Petrol / CNG / Diesel', '101.64bhp@6000rpm', '7','FWD', 'MUV', 'Maruti Ertiga is a 7 seater MUV car in a price range of Rs. 8.64 Lakh to 13.08 Lakh in India. Ertiga is offered with 1.5L petrol engine with CNG option in both manual and automatic transmission. Maruti Ertiga gives a mileage of 20.3 Kmpl on petrol and 26.11 km/kg on CNG. It is available in 9 variants and 7 beautiful colours. Considering the price and specs the Ertiga is a tough competition to Citroen C3 Aircross, Kia Carens and Mahindra Bolero Neo.', 1025000, 4.1, 'https://www.zigwheels.com/user-reviews/maruti-suzuki/ertiga');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('CarensC1', 'Kia Carens', '1482 - 1497 CC', '17.9 - 21 Kmpl', 'Automatic / Manual', 'Petrol / Diesel', '114.41bhp@4000rpm', '6','FWD', 'MUV', 'Kia Carens is a 6 seater MUV car in a price range of Rs. 10.44 Lakh to 19.44 Lakh in India with 3 star safety rating. Carens is offered with 1.5L diesel engine and 1.5L petrol engines in both manual and automatic transmission. Kia Carens gives a mileage of 17.9 Kmpl on petrol and 21 Kmpl on diesel. It is available in 23 variants and 6 beautiful colours. Considering the price and specs the Carens is a tough competition to Citroen C3 Aircross, Hyundai Alcazar and Hyundai Creta.', 1050000, 4.4, 'https://www.zigwheels.com/user-reviews/kia/carens');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('ScorpioC1', 'Mahindra Scorpio', '2184 CC', '14.67 - 15 kmpl', 'Automatic / Manual', ' Diesel', '130bhp@3750rpm', '7','RWD', 'MUV', 'Mahindra Scorpio is a 9 seater SUV car in a price range of Rs. 13.58 Lakh to 17.34 Lakh in India. Scorpio is offered with 2.2L diesel engine in manual transmission option only. It is available in 4 variants and 4 beautiful colours. Considering the price and specs the Scorpio is a tough competition to Tata Harrier.', 1520000, 4.4, 'https://www.zigwheels.com/user-reviews/mahindra/scorpio-classic');

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('TriberC1', 'Renault Triber', '999 CC', '18.2 - 20 Kmpl', 'Manual / Automatic', 'Petrol', '71.01bhp@6250rpm', '7','FWD', 'MUV', 'Renault Triber is a 7 seater MUV car in a price range of Rs. 5.99 Lakh to 8.97 Lakh in India. Triber is offered with 1L petrol engine in both manual and automatic transmission. Renault Triber gives a mileage of 20 kmpl on petrol. The ground clearance of Triber is 182 mm. It is available in 8 variants and 10 beautiful colours. Considering the price and specs the Triber is a tough competition to Hyundai Exter, Maruti Eeco and Maruti Ertiga.', 725000, 4.0, 'https://www.zigwheels.com/user-reviews/renault/triber');

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

INSERT INTO Cars (CarId, CarName, Engine, Mileage, Transmission, FuelType, MaxPower, SeatingCapacity, DriverType, BodyType, Description, Price, CustReview, CustReviewLink)
VALUES ('CarId', 'CarName', 'Engine', 'Mileage', 'Transmission', 'FuelType', 'MaxPower', 'SeatingCapacity','DriverType', 'BodyType', 'Descrpition', 'Price', CustReview, 'CustReviewLink');

SELECT * FROM Cars;
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE admin (
    adminID INT PRIMARY KEY IDENTITY(1,1),
	Role VARCHAR(50) NOT NULL,
	Department VARCHAR(50) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Address VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20),
    Username VARCHAR(50) UNIQUE NOT NULL,  -- New field for username
    Password VARCHAR(100) NOT NULL,        -- New field for password
    RegistrationDate DATETIME DEFAULT GETDATE()
);

INSERT INTO admin (Role, Department, FirstName, LastName, Email, Address, ContactNumber, Username, Password)
VALUES ('Manager', 'Sales', 'Anthony', 'Pinto', 'anthonypinto@example.com', '123 Main Street', '1234567890', 'Pinto', 'password123');

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE InventoryStatus (
    CarID VARCHAR(50) PRIMARY KEY, -- Assuming CarID is the primary key in the Cars table
    AvailableCount INT NOT NULL,
    MaxCapacity INT NOT NULL,
    FOREIGN KEY (CarID) REFERENCES Cars(CarID) -- Assuming CarID references the primary key in the Cars table
);

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- Insert queries for InventoryStatus table
INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('BalenoC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('PunchC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('WagonRC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('SwiftC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('i10_NiosC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('KwidC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('DzireC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('AmazeC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('AuraC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('CiazC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('Tata Tigor', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('VernaC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('BrezzaC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('NexonC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('CretaC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('SeltosC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('XUV300C1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('MagniteC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('BoleroC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('InnovaC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('ErtigaC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('CarensC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('ScorpioC1', 7, 7);

INSERT INTO InventoryStatus (CarId, AvailableCount, MaxCapacity)
VALUES ('TriberC1', 7, 7);

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


SELECT * FROM Customer;
SELECT * FROM admin;
SELECT * FROM Cars;
SELECT * FROM InventoryStatus;


SELECT COUNT(*) FROM Customer;
SELECT COUNT(*) FROM admin;
SELECT COUNT(*) FROM Cars;
SELECT COUNT(*) FROM InventoryStatus;

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- Create a table to store car colors
CREATE TABLE CarColors (
    ColorId INT PRIMARY KEY IDENTITY(1,1),
     CarId VARCHAR(50),
    Color1 VARCHAR(50),
    Color2 VARCHAR(50),
    Color3 VARCHAR(50),
    FOREIGN KEY (CarId) REFERENCES Cars(CarId)
);


INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('BalenoC1', 'Silver', 'Beige', 'Blue');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('PunchC1', 'Beige', 'Red', 'White');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('WagonRC1', 'White', 'Blue', 'Black');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('SwiftC1', 'Green', 'Red', 'White');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('i10_NiosC1', 'Beige', 'Silver', 'White');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('KwidC1', 'Red', 'Black', 'White');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('DzireC1', 'Green', 'White', 'Black');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('AmazeC1', 'Green', 'White', 'Blue');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('AuraC1', 'Beige', 'Blue', 'Black');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('CiazC1', 'Beige', 'White', 'Green');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('Tata Tigor', 'Blue', 'White', 'Silver');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('VernaC1', 'Red', 'Black', 'Beige');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('BrezzaC1', 'Beige', 'Red', 'Silver');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('NexonC1', 'Green', 'Red', 'Blue');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('CretaC1', 'Blue', 'Beige', 'Red');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('SeltosC1', 'Green', 'White', 'Red');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('XUV300C1', 'Red', 'Silver', 'Beige');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('MagniteC1', 'White', 'Blue', 'Beige');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('BoleroC1', 'Red', 'Black', 'Silver');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('InnovaC1', 'Blue', 'Silver', 'Black');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('ErtigaC1', 'Green', 'Beige', 'White');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('CarensC1', 'Beige', 'Blue', 'Green');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('ScorpioC1', 'Red', 'Blue', 'Black');
INSERT INTO CarColors (CarId, Color1, Color2, Color3) VALUES ('TriberC1', 'Red', 'White', 'Green');

SELECT * FROM CarColors

-----------------------------------------------------------------------------------------------------------------------------
-- Create the [Order] table
CREATE TABLE Orders(
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CarID VARCHAR(50) NOT NULL,
    CustomerID INT NOT NULL,
    Username VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Cart BIT NOT NULL DEFAULT 0,
    Ordered BIT NOT NULL DEFAULT 0,
    Delivered BIT NOT NULL DEFAULT 0,
    Status VARCHAR(50),
    Message TEXT
);

-- Add foreign key constraint after table creation
ALTER TABLE Orders
ADD CONSTRAINT FK_Customer_Order FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    CONSTRAINT FK_Car_Order FOREIGN KEY (CarId) REFERENCES Cars(CarId);

--- Add check constraints after table creation
ALTER TABLE Orders
ADD CONSTRAINT CHK_Cart_Order CHECK (Cart IN (0, 1));

ALTER TABLE Orders
ADD CONSTRAINT CHK_Ordered_Order CHECK (Ordered IN (0, 1));

ALTER TABLE Orders
ADD CONSTRAINT CHK_Delivered_Order CHECK (Delivered IN (0, 1));

ALTER TABLE Orders
ADD CONSTRAINT CHK_Order_Status CHECK (Status IN ('Pending', 'Processing', 'Delivered', 'ToBeDeleted', 'Cancelled'));

ALTER TABLE Orders
ADD CONSTRAINT CHK_Only_One_Status CHECK (
        (Cart = 1 AND Ordered = 0 AND Delivered = 0) OR
        (Cart = 0 AND Ordered = 1 AND Delivered = 0) OR
        (Cart = 0 AND Ordered = 0 AND Delivered = 1) OR
        (Cart = 0 AND Ordered = 0 AND Delivered = 0)
);


-- Create the function dbo.CheckAvailableCount if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.CheckAvailableCount') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
    EXEC('
    CREATE FUNCTION dbo.CheckAvailableCount (@CarID VARCHAR(50))
    RETURNS BIT
    AS
    BEGIN
        DECLARE @AvailableCount INT;

        SELECT @AvailableCount = COUNT(*)
        FROM InventoryStatus
        WHERE CarID = @CarID AND AvailableCount > 0;

        RETURN CASE WHEN @AvailableCount > 0 THEN 1 ELSE 0 END;
    END;
    ');
END;



-- Add check constraint using the function
--ALTER TABLE Orders
--ADD CONSTRAINT CHK_Available_Count CHECK (
--    (Delivered = 0) OR (Delivered = 1 AND dbo.CheckAvailableCount(CarID) = 1)
--);


------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- Create OrderHistory table if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderHistory]') AND type in (N'U'))
BEGIN
    CREATE TABLE OrderHistory (
		OrderHis INT PRIMARY KEY IDENTITY(1,1), 
        OrderID INT,
        CarID VARCHAR(50) NOT NULL,
        CustomerID INT NOT NULL,
        Username VARCHAR(100) NOT NULL,
        Price DECIMAL(10, 2) NOT NULL,
        Cart BIT NOT NULL,
        Ordered BIT NOT NULL,
        Delivered BIT NOT NULL,
        Status VARCHAR(50),
        Message TEXT,
        MovedOn DATETIME DEFAULT GETDATE() -- Add a column to track the date/time of the move
        -- Add additional columns if needed
    );
END;



-- Move orders with status 'ToBeDeleted' to OrderHistory table
INSERT INTO OrderHistory (OrderID, CarID, CustomerID, Username, Price, Cart, Ordered, Delivered, Status, Message)
SELECT OrderID, CarID, CustomerID, Username, Price, Cart, Ordered, Delivered, Status, Message
FROM Orders
WHERE Status = 'ToBeDeleted';

-- Delete orders with status 'ToBeDeleted' from the Orders table
DELETE FROM Orders
WHERE Status = 'ToBeDeleted';


select * from Orders
select * from Customer
select * from OrderHistory
select * from Cars
select * from InventoryStatus

UPDATE InventoryStatus SET AvailableCount = 1 WHERE CarID = 'HarrierC1';
