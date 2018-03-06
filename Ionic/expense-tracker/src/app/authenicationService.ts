import { Injectable } from "@angular/core";

@Injectable()
export class AuthenicationService{

    checkLogin(user){
        if(user.username == "ADMIN" && user.password == "ADMIN123")
            return true;
        else
            return false;
    }
}

