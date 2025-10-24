class User {
    constructor(userId, name, email, contactNumber) {
        this.userId = userId; // PK
        this.name = name;
        this.email = email;
        this.contactNumber = contactNumber;
    }
}

class Accommodations {
    constructor(accommodationsId, userId, roomId, reservationId) {
        this.accommodationsId = accommodationsId; // PK
        this.userId = userId; // FK 
        this.roomId = roomId; // FK 
        this.reservationId = reservationId; // FK 
    }
}

class RoomNumber {
    constructor(roomId, accommodationsId, price, bedSpaces, status) {
        this.roomId = roomId; // PK
        this.accommodationsId = accommodationsId; // FK
        this.price = price;
        this.bedSpaces = bedSpaces;
        this.status = status;
    }
}

class Reservation {
    constructor(reservationId, userId, accommodationsId, roomId, paymentStatus, startDate, endDate) {
        this.reservationId = reservationId; // PK
        this.userId = userId; // FK
        this.accommodationsId = accommodationsId; // FK
        this.roomId = roomId; // FK
        this.paymentStatus = paymentStatus;
        this.startDate = startDate;
        this.endDate = endDate;
    }
}

class Review {
    constructor(reviewId, userId, accommodationsId, roomId, rating, comment, date) {
        this.reviewId = reviewId; // PK
        this.userId = userId; // FK
        this.accommodationsId = accommodationsId; // FK
        this.roomId = roomId; // FK
        this.rating = rating;
        this.comment = comment;
        this.date = date;
    }
}

class Staff {
    constructor(workerId, occupation, contactNumber, accommodationsId) {
        this.workerId = workerId; // PK
        this.occupation = occupation;
        this.contactNumber = contactNumber;
        this.accommodationsId = accommodationsId; // FK 
    }
}

class Payment {
    constructor(paymentId, reservationId, paymentStatus, paymentDate, discount) {
        this.paymentId = paymentId; // PK
        this.reservationId = reservationId; // FK 
        this.paymentStatus = paymentStatus;
        this.paymentDate = paymentDate;
        this.discount = discount;
    }
}

class Service {
    constructor(serviceId, serviceType, price) {
        this.serviceId = serviceId; // PK
        this.serviceType = serviceType;
        this.price = price;
    }
}