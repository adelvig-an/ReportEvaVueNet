<template>
    <div class="report-component">
        <h1>Страница отчетов</h1>
       
    </div>
</template>

<script lang="js">
    import { defineComponent } from 'vue';

    //export default defineComponent({
    //    data() {
    //        return {
    //            loading: false,
    //            post: null
    //        };
    //    },
    //    async created() {
    //        // fetch the data when the view is created and the data is
    //        // already being observed
    //        await this.fetchData();
    //    },
    //    watch: {
    //        // call again the method if the route changes
    //        '$route': 'fetchData'
    //    },
    //    methods: {
    //        async fetchData() {
    //            this.post = null;
    //            this.loading = true;

    //            var response = await fetch('weatherforecast');
    //            if (response.ok) {
    //                this.post = await response.json();
    //                this.loading = false;
    //            }
    //        }
    //    },
    //});
</script>

<style scoped>
th {
    font-weight: bold;
}

th, td {
    padding-left: .5rem;
    padding-right: .5rem;
}

.weather-component {
    text-align: center;
}

table {
    margin-left: auto;
    margin-right: auto;
}
</style>
