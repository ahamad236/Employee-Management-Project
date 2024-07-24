import axios from 'axios'
import { Employee } from "../dataStruct/Employee"

export class EmployeeService {
    ApiUrl: string = "https://localhost:7152/api";

    GetAllEmployees() {
        return axios.get(this.ApiUrl + "/employees");
    }

    GetEmployeeByID(employeeID: number) {
        return axios.get(this.ApiUrl + "/employees/" + employeeID);
    }

    AddEmployee(employee: Employee) {
        return axios.post(this.ApiUrl + "/employees", employee);
    }

    DeleteEmployee(employeeID: number) {
        return axios.delete(this.ApiUrl + "/employees/"+ employeeID)
    }

    UpdateEmployee(employeeID: number, employee: Employee) {
        return axios.put(this.ApiUrl+"/employees/"+employeeID, employee)
    }

}