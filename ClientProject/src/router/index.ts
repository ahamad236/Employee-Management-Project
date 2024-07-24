import { createRouter, createWebHistory } from "vue-router"
import LogIn from "../components/LoginComponent.vue"
import Home from "../components/HomeComponent.vue"
import AboutUs from "../components/AboutUsComponent.vue"
import ContactUs from "../components/ContactUsComponent.vue"
import LogOut from "../components/LogOut.vue"
import AddEmployee from "../components/AddEmployee.vue"
import UpdateEmployee from "../components/UpdateEmployee.vue"

const routes = [
    {
        path: "/",
        name: "LogIn",
        component: LogIn
    },
    {
        path: "/home",
        name: "Home",
        component: Home,
    },
    {
        path: "/aboutUs",
        name: "AboutUs",
        component: AboutUs
    },
    {
        path: "/contactUs",
        name: "ContactUs",
        component: ContactUs
    },
    {
        path: "/logOut",
        name: "LogOut",
        component: LogOut
    },
    {
        path: "/addEmployee",
        name: "AddEmployee",
        component: AddEmployee
    },
    {
        path: "/updateEmployee/:employeeID",
        name: "UpdateEmployee",
        component: UpdateEmployee
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router