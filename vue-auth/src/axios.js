import axios from 'axios'

axios.defaults.baseURL='http://localhost:59723';
axios.defaults.headers.common['Authorization']='Bearer'+ localStorage.getItem('token');//оптимизация кода,чтобы не писать его много раз