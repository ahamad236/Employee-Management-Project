import axios from 'axios'
import type { Admin } from '../dataStruct/Admin'

export class AdminService {

    ApiUrl: string = "https://localhost:7152/api";

    //LogIn(admin: Admin) {
    //    try {
    //        return axios.get(this.ApiUrl + "/admins/", admin)
    //    }
    //    catch (ex) {
    //        console.log("Exception in Client is : " + ex);
    //    }
    //    finally {
    //        console.log("Finally in Client is : ");
    //    }
    //}



    LogIn(admin: Admin) {
        return axios.get(this.ApiUrl + "/admins/" + admin.adminName + "/" + admin.password);
    }


}
