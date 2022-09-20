
<script>
import {mapGetters} from 'vuex'
export default {
    name:'NAV',
    props:['username'],
    methods:{
        handleClick(){
            localStorage.removeItem('access_token');
            this.$store.dispatch('username', null);
            this.$router.push('/');
        }
    },    
    computed: {
        ...mapGetters(['username'])
    }    
}
</script>