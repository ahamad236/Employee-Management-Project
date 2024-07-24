import { createApp } from 'vue'
import App from './App.vue'
import router from "./router"

const app = createApp(App)
app.use(router)

//app.config.globalProperties.ApiUrl = "https://localhost:7152";

app.mount('#app')
