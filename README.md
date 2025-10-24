PlantUML :
@startuml
entity User {
    * User_ID
    --
    Name
    Email
    Contact_number
}

entity Accommodations {
    * Accommodations_ID
    --
    User_ID            ' FK → User.User_ID
    Room_ID            ' FK → Room_number.Room_ID
    Reservation_ID     ' FK → Reservation.Reservation_ID
    Location
}

entity Reservation {
    * Reservation_ID
    --
    User_ID            ' FK → User.User_ID
    Accommodations_ID  ' FK → Accommodations.Accommodations_ID
    Room_ID            ' FK → Room_number.Room_ID
    Payment_Status     ' FK -> Payment.Payment_status
    Start_date
    End_date
    Service_type       ' FK -> Service.Service_type
}

entity Room_number {
    * Room_ID
    --
    Accommodations_ID  ' FK → Accommodations.Accommodations_ID
    Price
    Bed_spaces
    Status
}

entity Review {
* Review_ID
    --
    User_ID            ' FK → User.User_ID
    Accommodations_ID  ' FK → Accommodations.Accommodations_ID
    Room_ID            ' FK → Room_number.Room_ID
    Rating
    Comment
    Date
}

entity Payment {    
    * Payment_ID
    --
    Payment_status
    Payment_date
    Discount
}

entity Service {
    * Service_ID
    --
    Service_type
    Price
    
}

entity Staff {
    * worker_ID
    --
    Occupation  
    Contact_number
}

User "1" -- "0..*" Reservation : makes

User "1" -- "0..*" Review : writes

Accommodations "1" -- "1..*" Room_number : contains

Accommodations "1" -- "0..1" Review : has

Reservation "0..1" -- "1..*" Room_number : books

Reservation "1" -- "0..*" Service : includes

Payment "1" -- "1" Reservation : pays for

Staff "0..*" -- "1" Accommodations : has

@enduml

![alt text](https://img.plantuml.biz/plantuml/png/rLMzJiCm4Dxp55OMf4gDwDe15IX820HLA-R8E2vOhUqgTbfL5IiFm2Fo9DWNEx7JT2aJMMBdlllkvpix4wLngIk-JX8gDDDxzAfeYGu9Ciy0Dld357R38RoUCQUmkEEOhM5rAuN6HEUYuc-qJ3uRhcj29EUom9f9eHhM-7E7tuL4mNE1xX_HpzStsB8mfxcK_1GOR7LAcSFLFjGGR26sTsrzMbiMuy3rIHBO1oK6gAQ-7izpYZjgKm2ERLb_Hy_fpWplkIajNsYiAzNw3A-yAVCG1H3mMjWfoaruDngYQ3SBqmj6QAxt6nfcOHYTAGiXOM_R7DlU1hcwflwvJxFI18VL3IrojS64DcNP2aErjupk0g7jzjzfF3SKujqTNMwrXFNKAjRMwcH61sjp1Nlfuufx1i9_QgPWoXIHbOdK1d2gDztqKn2JHxCHgnLoQRnSDamxMQwEBguNGgfDVL3HYMiBxhvqb1eNb5vcsI2DplSOSRmoez6FWyaOert9jCLqxZwF7jNeOBB7YDX4c3ZjP4ACWX0Vs433n1pW5F-RbAkkHvIyLsACc23hgh3vU_cRnBkzsE2zGajP9adTVCVbi9rAND8JAWhusVm2)

