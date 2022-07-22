<!-- <template>
    <nav class="navbar navbar-expand navbar-light fixed-top">
        <div class="container">
              <router-link to="/" class="navbar-brand">Home</router-link>
                    <div class="collapse navbar-collapse">
                          <ul class="navbar-nav ml-auto" v-if="!username">
                          <li class="nav-item">
                              <router-link to="/login" class="nav-link">Login</router-link>
                               </li>
                               <li class="nav-item">
                               <router-link to="/register" class="nav-link">Sign up</router-link>
                               </li>  
                            </ul>

                            <ul class="navbar-nav ml-auto" v-else>
                              <li class="nav-item">
                                  <a href="javascript:void(0)" @click="handleClick" class="nav-link">Logout</a>
                               </li>                               
                            </ul>
</div>
</div>
</nav>

</template> -->

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