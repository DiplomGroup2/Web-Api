import axios from 'axios'

/*axios.defaults.baseURL='http://localhost:59723';*/
/*axios.defaults.baseURL ='http://lavira-001-site1.atempurl.com/';*/
axios.defaults.baseURL ='https://diplom.somee.com/';
axios.defaults.headers.common['Authorization']='Bearer'+ localStorage.getItem('token');//оптимизация кода,чтобы не писать его много раз